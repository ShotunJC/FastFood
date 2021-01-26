using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FastFoods
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                string ConnStr = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFood; Integrated Security=SSPI";

                SqlConnection MyConn = new SqlConnection(ConnStr);
                MyConn.Open();
                string insertQuery1 = "insert into Orders(OrderNum,CustName,CustAddress,ContactNum,TotalPrice)values (@orderNum,@custName,@custAddress,@contactNum,@totalPrice)";
                SqlCommand cmd = new SqlCommand(insertQuery1, MyConn);
                cmd.Parameters.AddWithValue("@orderNum", int.Parse(OrderNum.Text));
                cmd.Parameters.AddWithValue("@custName", CustName.Text);
                cmd.Parameters.AddWithValue("@custAddress", CustAddress.Text);
                cmd.Parameters.AddWithValue("@contactNum", ContactNum.Text);
                cmd.Parameters.AddWithValue("@totalPrice", int.Parse(TotalPrice.Text));
                cmd.ExecuteNonQuery();

                string insertQuery2 = "insert into OrderItems(LineItem,Descr,QTY,Price,OrderNum)values (@lineItem,@descr,@qty,@price,@orderNum)";
                SqlCommand cmd2 = new SqlCommand(insertQuery2, MyConn);
                cmd2.Parameters.AddWithValue("@orderNum", int.Parse(iOrderNum.Text));
                cmd2.Parameters.AddWithValue("@descr", Description.Text);
                cmd2.Parameters.AddWithValue("@qty", int.Parse(qty.Text));
                cmd2.Parameters.AddWithValue("@price", int.Parse(Price.Text));
                cmd2.Parameters.AddWithValue("@lineItem", int.Parse(LineItem.Text));
                cmd2.ExecuteNonQuery();

                string insertQuery3 = "insert into Delivery(DNum,DName,DriverNum,OrderNum)values (@dNum,@dName,@driverNum,@orderNum)";
                SqlCommand cmd3 = new SqlCommand(insertQuery3, MyConn);
                cmd3.Parameters.AddWithValue("@orderNum", int.Parse(dOrderNum.Text));
                cmd3.Parameters.AddWithValue("@dNum", DeliveryNum.Text);
                cmd3.Parameters.AddWithValue("@dName", DriverName.Text);
                cmd3.Parameters.AddWithValue("@driverNum", int.Parse(DriverContact.Text));
                cmd3.ExecuteNonQuery();


                Response.Write("Order Has been added Successfully");

                MyConn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

            OrderNum.Text = "";
            CustName.Text = "";
            CustAddress.Text = "";
            ContactNum.Text = "";
            TotalPrice.Text = "";
            iOrderNum.Text = "";
            Description.Text = "";
            qty.Text = "";
            Price.Text = "";
            LineItem.Text = "";
            dOrderNum.Text = "";
            DeliveryNum.Text = "";
            DriverName.Text = "";
            DriverContact.Text = "";
        }

        protected void search_Click(object sender, EventArgs e)
        {

            try
            {

                string ConnStr = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFood; Integrated Security=SSPI";

                SqlConnection MyConn = new SqlConnection(ConnStr);
                MyConn.Open();
                string searchQuery1 = "select * from Orders where Ordernum='" + int.Parse(OrderNum.Text) + "'";
                SqlCommand com = new SqlCommand(searchQuery1, MyConn);
                SqlDataReader reader = null;


                reader = com.ExecuteReader();
                if (reader.Read())
                {
                    OrderNum.Text = reader.GetValue(1).ToString();
                    CustName.Text = reader.GetValue(2).ToString();
                    CustAddress.Text = reader.GetValue(3).ToString();
                    ContactNum.Text = reader.GetValue(4).ToString();
                    TotalPrice.Text = reader.GetValue(5).ToString();
                }
                else
                {
                    Response.Write("Record was not Found...!");
                }
                reader.Close();

                string searchQuery2 = "select * from OrderItems where OrderNum='" + int.Parse(OrderNum.Text) + "'";
                SqlCommand com2 = new SqlCommand(searchQuery2, MyConn);
                SqlDataReader reader2 = null;


                reader2 = com2.ExecuteReader();
                if (reader2.Read())
                {
                    iOrderNum.Text = reader2.GetValue(5).ToString();
                    Description.Text = reader2.GetValue(2).ToString();
                    qty.Text = reader2.GetValue(3).ToString();
                    Price.Text = reader2.GetValue(4).ToString();
                    LineItem.Text = reader2.GetValue(1).ToString();
                }
                else
                {
                    Response.Write("Record was not Found...!");
                }

                reader2.Close();

                string searchQuery3 = "select * from Delivery where OrderNum='" + int.Parse(OrderNum.Text) + "'";
                SqlCommand com3 = new SqlCommand(searchQuery2, MyConn);
                SqlDataReader reader3 = null;


                reader3 = com3.ExecuteReader();
                if (reader3.Read())
                {
                    dOrderNum.Text = reader3.GetValue(4).ToString();
                    DeliveryNum.Text = reader3.GetValue(1).ToString();
                    DriverName.Text = reader3.GetValue(2).ToString();
                    DriverContact.Text = reader3.GetValue(3).ToString();
                }
                else
                {
                    Response.Write("Record was not Found...!");
                }
                reader3.Close();

                Response.Write("Order Has been retrieved Successfully");

                MyConn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }


        }

        protected void update_Click(object sender, EventArgs e)
        {
            try
            {

                string ConnStr = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFood; Integrated Security=SSPI";

                SqlConnection MyConn = new SqlConnection(ConnStr);
                MyConn.Open();
                string insertQuery1 = "UPDATE Orders SET OrderNum = @orderNum,CustName = @custName,CustAddress = @custAddress,ContactNum = @contactNum,TotalPrice = @totalPrice WHERE OrderNum = '" + int.Parse(OrderNum.Text) + "'";
                SqlCommand cmd = new SqlCommand(insertQuery1, MyConn);
                cmd.Parameters.AddWithValue("@orderNum", int.Parse(OrderNum.Text));
                cmd.Parameters.AddWithValue("@custName", CustName.Text);
                cmd.Parameters.AddWithValue("@custAddress", CustAddress.Text);
                cmd.Parameters.AddWithValue("@contactNum", ContactNum.Text);
                cmd.Parameters.AddWithValue("@totalPrice", int.Parse(TotalPrice.Text));
                cmd.ExecuteNonQuery();

                string insertQuery2 = "UPDATE OrderItems SET LineItem = @lineItem,Descr = @descr,QTY = @qty,Price = @price,OrderNum = @orderNum WHERE OrderNum = '" + int.Parse(iOrderNum.Text) + "'";
                SqlCommand cmd2 = new SqlCommand(insertQuery2, MyConn);
                cmd2.Parameters.AddWithValue("@orderNum", int.Parse(iOrderNum.Text));
                cmd2.Parameters.AddWithValue("@descr", Description.Text);
                cmd2.Parameters.AddWithValue("@qty", int.Parse(qty.Text));
                cmd2.Parameters.AddWithValue("@price", int.Parse(Price.Text));
                cmd2.Parameters.AddWithValue("@lineItem", int.Parse(LineItem.Text));
                cmd2.ExecuteNonQuery();

                string insertQuery3 = "UPDATE Delivery SET DNum = @dNum,DName = @dName,DriverNum = @driverNum,OrderNum = @orderNum WHERE OrderNum = '" + int.Parse(OrderNum.Text) + "'";
                SqlCommand cmd3 = new SqlCommand(insertQuery3, MyConn);
                cmd3.Parameters.AddWithValue("@orderNum", int.Parse(dOrderNum.Text));
                cmd3.Parameters.AddWithValue("@dNum", DeliveryNum.Text);
                cmd3.Parameters.AddWithValue("@dName", DriverName.Text);
                cmd3.Parameters.AddWithValue("@driverNum", int.Parse(DriverContact.Text));
                cmd3.ExecuteNonQuery();


                Response.Write("Order Has been updated Successfully");

                MyConn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
            OrderNum.Text = "";
            CustName.Text = "";
            CustAddress.Text = "";
            ContactNum.Text = "";
            TotalPrice.Text = "";
            iOrderNum.Text = "";
            Description.Text = "";
            qty.Text = "";
            Price.Text = "";
            LineItem.Text = "";
            dOrderNum.Text = "";
            DeliveryNum.Text = "";
            DriverName.Text = "";
            DriverContact.Text = "";
        }

        protected void delete_Click(object sender, EventArgs e)
        {

            string ConnStr = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=FastFood; Integrated Security=SSPI";
            SqlConnection MyConn = new SqlConnection(ConnStr);
            MyConn.Open();

            string sqlStatement1 = "DELETE FROM OrderItems WHERE OrderNum = @OrderNum";
           

                SqlCommand cmd1 = new SqlCommand(sqlStatement1, MyConn);
                cmd1.Parameters.AddWithValue("@OrderNum", int.Parse(iOrderNum.Text));
                cmd1.CommandType = System.Data.CommandType.Text;
                cmd1.ExecuteNonQuery();



            string sqlStatement2 = "DELETE FROM Delivery WHERE OrderNum = @OrderNum";



                SqlCommand cmd2 = new SqlCommand(sqlStatement2, MyConn);
                cmd2.Parameters.AddWithValue("@OrderNum", int.Parse(dOrderNum.Text));
                cmd2.CommandType = System.Data.CommandType.Text;
                cmd2.ExecuteNonQuery();

 
            string sqlStatement = "DELETE FROM Orders WHERE OrderNum = @OrderNum";


                SqlCommand cmd3 = new SqlCommand(sqlStatement, MyConn);
                cmd3.Parameters.AddWithValue("@OrderNum", int.Parse(OrderNum.Text));
                cmd3.CommandType = System.Data.CommandType.Text;
                cmd3.ExecuteNonQuery();

            Response.Write("Order Has been deleted Successfully");

            MyConn.Close();

            OrderNum.Text = "";
            CustName.Text = "";
            CustAddress.Text = "";
            ContactNum.Text = "";
            TotalPrice.Text = "";
            iOrderNum.Text = "";
            Description.Text = "";
            qty.Text = "";
            Price.Text = "";
            LineItem.Text = "";
            dOrderNum.Text = "";
            DeliveryNum.Text = "";
            DriverName.Text = "";
            DriverContact.Text = "";

        }

        protected void clear_Click(object sender, EventArgs e)
        {
            OrderNum.Text = "";
            CustName.Text = "";
            CustAddress.Text = "";
            ContactNum.Text = "";
            TotalPrice.Text = "";
            iOrderNum.Text = "";
            Description.Text = "";
            qty.Text = "";
            Price.Text = "";
            LineItem.Text = "";
            dOrderNum.Text = "";
            DeliveryNum.Text = "";
            DriverName.Text = "";
            DriverContact.Text = "";

            Response.Write("Cleared");
        }
    }
    
}