﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Framework;
using System.Windows.Forms;

public class FAQ
{
    public static Boolean IsPicklistForDisposal(String picklist_id)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM ForDisposals WHERE disposed_to IS NULL AND trans_id = '" + picklist_id + "'").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;
    }


    public static String GetPicklistID(String order_id)
    {
        return DataSupport.RunDataSet("SELECT picklist FROM PicklistDetails WHERE order_id = '"+order_id+"'; ").Tables[0].Rows[0][0].ToString();
    }

    public static DataTable GetPickedItems(String picklist,String order_id)
    {
        DataTable dt = DataSupport.RunDataSet(@"SELECT *
                            FROM
                            (
	                            SELECT *
	                            ,
	                              (SELECT  TOP 1 order_id 
		                            FROM ForResolutions B
		                            WHERE B.trans_id = A.picklist
		                              AND B.product = A.product
		                              AND B.uom = A.uom
		                              AND B.lot_no = A.lot_no
		                              AND B.expiry = A.expiry
	                               )
	                               [exist]
	                            FROM PicklistDetails A
	                            WHERE picklist='"+picklist+@"' AND order_id = '"+order_id+@"'
                            ) T 
                            WHERE exist IS NULL

   
                               "

                                        ).Tables[0];

        return dt;

    }


    public static DataTable GetLocationsFromPhysicalCount(String physical_count_id)
    {
        DataTable dt = DataSupport.RunDataSet("SELECT DISTINCT Location FROM PhysicalCountDetailItems WHERE phcount = '" + physical_count_id + "'").Tables[0];
       
        return dt;
    }


    public static Boolean DoesPhysicalCountExist(String physical_count_id)
    {
        DataTable dt = DataSupport.RunDataSet("SELECT phcount_id FROM PhysicalCounts WHERE phcount_id=@id", "id", physical_count_id).Tables[0];
        if (dt.Rows.Count <= 0)
            return false;
        return true;
    }




    public static String GetReleaseID(String trip_id)
    {
        return DataSupport.RunDataSet("SELECT release_id FROM Releases WHERE trip= @trip", "trip", trip_id).Tables[0].Rows[0][0].ToString();
    }

    public static DataTable GetPickedOrder(String order_id)
    {
        DataTable dt = DataSupport.RunDataSet("SELECT * FROM PicklistDetails WHERE order_id = @order_id ", "order_id", order_id).Tables[0];

        return dt;
    }

    public static Boolean DoesReleasingExist(String trip_id)
    {
        DataTable dt = DataSupport.RunDataSet("SELECT * FROM Releases WHERE trip = @trip; ", "trip", trip_id).Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;
    }


    public static DataTable GetTripDetails(String trip_id)
    {
        return DataSupport.RunDataSet("SELECT RD.trip, RD.order_id, RD.drop_sequence FROM ReleaseTripDetails RD INNER JOIN ReleaseOrders RO ON RD.order_id = RO.order_id  WHERE trip = @trip AND RO.status='FOR RELEASING' ORDER BY drop_sequence ; ", "trip", trip_id).Tables[0];
    }

    public static DataTable GetOrdersFromPicklist(String picklist_id)
    {
        return DataSupport.RunDataSet(@"SELECT order_id FROM PicklistDetails WHERE picklist=@picklist_id
                        ", "picklist_id", picklist_id).Tables[0];
    }

    public static DataTable WhereAreReservedProductsInWarehouse(String product, String uom)
    {
        return DataSupport.RunDataSet(@"SELECT location, lot_no, expiry, (reserved_qty - to_be_picked_qty)[reserved_qty]
                        FROM LocationProductsLedger 
                        WHERE  product = @product AND uom = @uom
                        AND (reserved_qty - to_be_picked_qty) > 0
                        ORDER BY expiry 
                        ", "product", product, "uom", uom).Tables[0];
    }


    public static DataTable WhereAreProductsInWarehouse(String product, String uom)
    {
        return DataSupport.RunDataSet(@"SELECT location, lot_no, expiry, available_qty
                        FROM LocationProductsLedger 
                        WHERE  product = @product AND uom = @uom
                        AND available_qty >0
                        ORDER BY expiry DESC
                        ", "product", product, "uom", uom).Tables[0];
    }

    public static int HowManyPiecesInUOM(String product, String uom, int qty)
    {
        int result = 0;
        String sql = @"SELECT *,
                case_barcode
                ,
                CASE 
                   WHEN @uom='PIECES'
	                THEN  1
                   WHEN @uom = 'CASES'
                    THEN pcs_per_case
                   ELSE
                    (SELECT qty FROM ProductUOMs PU WHERE PU.product = L.product_id AND PU.uom = @uom ) 
                END
                 [IN_PIECES]
                FROM Products L
                WHERE product_id = @product";

        DataTable dt = DataSupport.RunDataSet(sql, "product", product, "uom", uom).Tables[0];
        result = int.Parse(dt.Rows[0]["IN_PIECES"].ToString()) * qty;
        return result;
    }

    public static int HowManyPiecesInWarehouse(String product_id)
    {
        int result = 0;
        String sql = @"SELECT *
                        ,CASE WHEN uom='CASES'
			                        THEN (SELECT pcs_per_case FROM Products WHERE product = product_id) * qty
	                          WHEN uom='PIECES'
			                        THEN qty
	                          ELSE 
			                        (SELECT qty FROM ProductUOMs PU WHERE PU.product = L.product AND PU.uom = L.uom ) * qty
                         END
                         [IN_PIECES]
                        FROM LocationProductsLedger L
                        WHERE product= @product
                        AND available_qty >0 AND expiry_status IS NULL AND expiry > GETDATE()";
        DataTable dt = DataSupport.RunDataSet(sql, "product", product_id).Tables[0];
        foreach (DataRow row in dt.Rows)
            result += int.Parse( row["IN_PIECES"].ToString());
        return result;
    }

    public static DataTable GetOrderDetails(String order_id)
    {
        return DataSupport.RunDataSet("SELECT * FROM ReleaseOrderDetails WHERE release_order = @id", "id", order_id).Tables[0]; ;
    }

    public static Boolean DoesOrderHaveStocks(String order_id)
    {
        DataTable detailsDT = DataSupport.RunDataSet("SELECT * FROM ReleaseOrderDetails WHERE release_order = @id", "id", order_id).Tables[0];
        foreach (DataRow row in detailsDT.Rows)
        {
            int pieces_in_warehouse = FAQ.HowManyPiecesInWarehouse(row["product"].ToString());
            int pieces_in_order = FAQ.HowManyPiecesInUOM(row["product"].ToString(), row["uom"].ToString(), int.Parse(row["qty"].ToString()));
            if (pieces_in_warehouse < pieces_in_order)
                return false;
        }

        return true;
    }

    public static DataTable GetLocations()
    {
        return DataSupport.RunDataSet("SELECT * FROM Locations").Tables[0];
    }

    public static String GetContainerType(String container_id)
    {
        return DataSupport.RunDataSet("SELECT type FROM Containers WHERE container_id='"+container_id+"' ").Tables[0].Rows[0][0].ToString();
    }

    public static String GetContainer(String putaway_id)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM Putaways WHERE putaway_id = '" + putaway_id + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return dt.Rows[0]["container"].ToString();

        return null;
    }

    public static Boolean DoesPicklistExist(String picklist_id)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM Picklists WHERE picklist_id = '" + picklist_id + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }



    public static DataTable GetPutawayDetails(String putaway_id)
    {
        return DataSupport.RunDataSet("SELECT * FROM PutawayDetails WHERE putaway = '" + putaway_id + "'; ").Tables[0];
    }

    public static Boolean IsNewLine(String location, String product, String uom, String lot_no, String expiry)
    {
        DataTable dt = DataSupport.RunDataSet("SELECT * FROM LocationProductsLedger WHERE location = '" + location + "' AND product='" + product + "' AND uom ='" + uom + "' AND lot_no = '" + lot_no + "' AND expiry='" + expiry + "'").Tables[0];
        if (dt.Rows.Count > 0)
            return true;

        return false;
    }
    //jomer
    public static Boolean INWrrNoExist(String wrrNo)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM [oms_db].[dbo].[IncomingShipmentRequests] WHERE wrrNo = '" + wrrNo + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }
    public static Boolean OutDocumentReferenceExist(String document_reference)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM [oms_db].[dbo].[OutgoingShipmentRequests] WHERE document_reference = '" + document_reference + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }
    public static DataTable getProduct(String product_id,DataRow dataRow)
    {
        return DataSupport.RunDataSet("SELECT * FROM products WHERE product_id = '" + product_id + "'; ").Tables[0];
    }
    public static String getCustomer(String CustumerName)
    {
        return DataSupport.RunDataSet("SELECT custName FROM customers WHERE custCode='" + CustumerName + "' ").Tables[0].Rows[0][0].ToString();
    }
    public static String GetNextReturnID(int mode)
    {
        if (mode == 1)
        {
            return DataSupport.RunDataSet(" Select ISNULL(max(returnID),0) + 1 from ReturnShipmentRequest").Tables[0].Rows[0][0].ToString();
        }
        else
        { return DataSupport.RunDataSet(" Select ISNULL(max(transID),0) + 1 from StocktransferRequest").Tables[0].Rows[0][0].ToString(); }
    }
    public static Boolean productPriceExist(String productCode, String uom,String type)
    {
        var dt = DataSupport.RunDataSet("select * from base_price  where product_code = '" + productCode + "' and uom = '" + uom + "' and priceType = '" + type + "'").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }
    public static Boolean InvoiceExist(String invoice)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM Global_ProductTrans WHERE siNo = '" + invoice + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }
    public static Boolean DrExist(String dr)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM Global_drTrans WHERE drNo = '" + dr + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }
    public static Boolean DrPOExist(String drPO)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM Global_drTrans WHERE poNo = '" + drPO + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }
    public static Boolean INPoExist(String Inpo)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM Global_ProductTrans WHERE poNo = '" + Inpo + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }
    public static Boolean ProductCode(String ProductCode)
    {
        var dt = DataSupport.RunDataSet("SELECT * FROM [oms_db].[dbo].[Products] WHERE [product_id] = '" + ProductCode + "' ").Tables[0];
        if (dt.Rows.Count > 0)
            return true;
        return false;

    }

}
