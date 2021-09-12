using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {

                Elec.Items.Add(new ListItem("Tostadora", "1"));
                Elec.Items.Add(new ListItem("Batidora", "2"));
                Elec.Items.Add(new ListItem("Licuadora", "3"));
            }
            Grafico.Visible = false;

        }
        protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            cl1.Text = "";
            cl2.Text = "";
            cl3.Text = "";
            Grafico.Src = "figura" + Elec.SelectedIndex.ToString() +".jpg";
            Grafico.Alt = "Grafico Electrodomestico";
            Grafico.Visible = true;
            if (Elec.SelectedIndex == 0) {
                res.Text = " Se seleciono Tostadora";
            }
            if (Elec.SelectedIndex == 1)
            {
                res.Text = " Se seleciono Batidora";
            }
            if (Elec.SelectedIndex == 2)
            {
                res.Text = " Se seleciono Licuadora";
            }
        }
         

        protected void Button1_Click1(object sender, EventArgs e)
        {
            cl1.Text = "";
            cl2.Text = "";
            cl3.Text = "";
            Grafico.Src = "proveedor" + Elec.SelectedIndex.ToString() + ".jpg";
            Grafico.Alt = "Grafico Electrodomestico";
            Grafico.Visible = true;
            if (Elec.SelectedIndex == 0)
            {
                res.Text = " Se seleciono proveedor Tostadora";
            }
            if (Elec.SelectedIndex == 1)
            {
                res.Text = " Se seleciono proveedor Batidora";
            }
            if (Elec.SelectedIndex == 2)
            {
                res.Text = " Se seleciono proveedor Licuadora";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            res.Text = " Cliente: Sandra Maria Vera TIPO: Premium";
            cl1.Text = "Cliente: Gabriel Huarsaya MACEDO Tipo:BASICO";
            cl2.Text = "Cliente: Ronald Machaca Tipo: PLATINUM";
            cl3.Text = "Cliente:Clara Sofia Tipo:PREMIUM";
        }
    }
}