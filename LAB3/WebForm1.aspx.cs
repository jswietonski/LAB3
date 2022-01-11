using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Collections;
using System.Data;
using LAB3;

namespace LAB3
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            DbManager.UPDATEpol(dc, JSTextBox1.Text);
            switch (DropDownList1.SelectedItem.Value)
            {
                case "0":
                    Image0.Style.Add("top", "0%");
                    Image0.Style.Add("left", "0%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "50%");
                    Image1.Style.Add("left", "50%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "100%");
                    Image2.Style.Add("left", "100%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "100%");
                    Image3.Style.Add("left", "0%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("top", "0%");
                    Image4.Style.Add("left", "100%");
                    Image4.Style.Add("position", "absolute");

                    break;
                case "1":
                    Image0.Style.Add("top", "0%");
                    Image0.Style.Add("left", "0%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "25%");
                    Image1.Style.Add("left", "25%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "50%");
                    Image2.Style.Add("left", "50%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "75%");
                    Image3.Style.Add("left", "75%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("top", "100%");
                    Image4.Style.Add("left", "100%");
                    Image4.Style.Add("position", "absolute");
                    break;
                case "2":
                    Image0.Style.Add("top", "0%");
                    Image0.Style.Add("left", "100%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "25%");
                    Image1.Style.Add("left", "75%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "50%");
                    Image2.Style.Add("left", "50%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "75%");
                    Image3.Style.Add("left", "25%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("bottom", "0%");
                    Image4.Style.Add("left", "0%");
                    Image4.Style.Add("position", "absolute");
                    break;
                case "3":
                    Image0.Style.Add("top", "50%");
                    Image0.Style.Add("left", "0%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "50%");
                    Image1.Style.Add("left", "25%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "50%");
                    Image2.Style.Add("left", "50%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "50%");
                    Image3.Style.Add("left", "75%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("top", "50%");
                    Image4.Style.Add("left", "100%");
                    Image4.Style.Add("position", "absolute");
                    break;
                case "4":
                    Image0.Style.Add("top", "0%");
                    Image0.Style.Add("left", "50%");
                    Image0.Style.Add("position", "absolute");

                    Image1.Style.Add("top", "25%");
                    Image1.Style.Add("left", "50%");
                    Image1.Style.Add("position", "absolute");

                    Image2.Style.Add("top", "50%");
                    Image2.Style.Add("left", "50%");
                    Image2.Style.Add("position", "absolute");

                    Image3.Style.Add("top", "75%");
                    Image3.Style.Add("left", "50%");
                    Image3.Style.Add("position", "absolute");

                    Image4.Style.Add("top", "100%");
                    Image4.Style.Add("left", "50%");
                    Image4.Style.Add("position", "absolute");
                    break;

            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            DbManager.UPDATEroz(dc, JSTextBox1.Text);
            if (RadioButtonList1.SelectedItem.Value == "s")
            {
                Image0.Style.Add("height", "30px");
                Image0.Style.Add("width", "30px");

                Image1.Style.Add("height", "30px");
                Image1.Style.Add("width", "30px");

                Image2.Style.Add("height", "30px");
                Image2.Style.Add("width", "30px");

                Image3.Style.Add("height", "30px");
                Image3.Style.Add("width", "30px");

                Image4.Style.Add("height", "30px");
                Image4.Style.Add("width", "30px");

            }
            if (RadioButtonList1.SelectedItem.Value == "m")
            {
                Image0.Style.Add("height", "45px");
                Image0.Style.Add("width", "45px");
                Image1.Style.Add("height", "45px");
                Image1.Style.Add("width", "45px");
                Image2.Style.Add("height", "45px");
                Image2.Style.Add("width", "45px");
                Image3.Style.Add("height", "45px");
                Image3.Style.Add("width", "45px");
                Image4.Style.Add("height", "45px");
                Image4.Style.Add("width", "45px");
            }
            if (RadioButtonList1.SelectedItem.Value == "x")
            {
                Image0.Style.Add("height", "60px");
                Image0.Style.Add("width", "60px");
                Image1.Style.Add("height", "60px");
                Image1.Style.Add("width", "60px");
                Image2.Style.Add("height", "60px");
                Image2.Style.Add("width", "60px");
                Image3.Style.Add("height", "60px");
                Image3.Style.Add("width", "60px");
                Image4.Style.Add("height", "60px");
                Image4.Style.Add("width", "60px");


            }
            ;
        }


        protected void JSButton1_Click1(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            if (DbManager.SELECT(dc, JSTextBox1.Text))
            {

                JSPanel1.Visible = true;
                JSPanel2.Visible = false;
                Label1.Text = JSTextBox1.Text;
                int maxID = DbManager.SELECTmaxID(dc);
                DbManager.INSERT(dc, maxID + 1, JSTextBox1.Text);
                Debug.WriteLine("Nie ma w bazie");

            }
            else
            {
                JSPanel1.Visible = true;
                JSPanel2.Visible = false;
                Label1.Text = JSTextBox1.Text;
                CustomValidator1.IsValid = false;
                Debug.WriteLine("Takie imie jest juz w bazie");
                List<string> list = DbManager.SELECTrow(dc, JSTextBox1.Text);
                Label2.Text = list.ElementAt(1);
                Label3.Text = list.ElementAt(2);
                Label4.Text = list.ElementAt(4);
                Label5.Text = list.ElementAt(5);
                Label6.Text = list.ElementAt(3);

            }


        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            //DropDownList dl = new DropDownList();
            //List<JSlista> JSusers = (List<JSlista>)Application["users"];
            //DropDownList2.Items.Clear();
            //foreach (JSlista item in JSusers)
            //{
            //    DropDownList2.Items.Add((string)item.getUz());
            //}
            //JSPanel1.Controls.Add(dl);
            List<string> list = DbManager.SELECTrow(dc, JSTextBox1.Text);
            Label2.Text = list.ElementAt(1);
            Label3.Text = list.ElementAt(2);
            Label4.Text = list.ElementAt(4);
            Label5.Text = list.ElementAt(5);
            Label6.Text = list.ElementAt(3);
            //Debug.WriteLine("Odswiezam");
        }

        protected void JSTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}