using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WX_PROV_CONSULTACLASIF
{
    public partial class Form_CLASIF_PROV : Form
    {
        public Form_CLASIF_PROV()
        {
            InitializeComponent();
        }
        Class.Consulta c = new Class.Consulta();
        private void BTN_CONSULTA_Click(object sender, EventArgs e)
        {
            c.documento = txt_documento.Text;
            DataSet dt = c.Select();

            if (dt.Tables[0].Rows.Count > 0)
            {
                LB_NOMBRE.Enabled = true;
                LB_NOMBRE.Text = "Nombre: " + dt.Tables[0].Rows[0]["CLIENTE"].ToString();

                lb_clasif.Enabled = true;
                lb_clasif.Text = "Clasificación: " + dt.Tables[0].Rows[0]["CALIF_CLI"].ToString();

                TX_DEUDATOTAL.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEUDA_TOTAL_USD"]).ToString();
                TX_DEUDATOTALFCC.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEUDA_TOTAL_FCC_USD"]).ToString();

               


            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            String selectedItem = comboBox1.SelectedItem.ToString();
            c.documento = txt_documento.Text;
            DataSet dt = c.Select();
            String CALIF_ACT = dt.Tables[0].Rows[0]["CALIF_CLI"].ToString();


            if (dt.Tables[0].Rows.Count > 0)
            {

                if (c.clasif(dt.Tables[0].Rows[0]["CALIF_CLI"].ToString()) > c.clasif(selectedItem.ToString()))
                    lb_Dev_Req.Text = "Devolución de Provisión";
                else if (c.clasif(dt.Tables[0].Rows[0]["CALIF_CLI"].ToString()) < c.clasif(selectedItem.ToString()))
                    lb_Dev_Req.Text = "Requerimiento de Provisión";
                else
                    lb_Dev_Req.Text = "";

                //Requerimiento
                if (CALIF_ACT == "0 - Normal")
                    //Requerimiento
                    if (selectedItem == "1 - CPP")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_1MAS"]).ToString();
                    else if (selectedItem == "2 - Deficiente")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_2MAS"]).ToString();
                    else if (selectedItem == "3 - Dudoso")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_3MAS"]).ToString();
                    else if (selectedItem == "4 - Perdida")
                         tx_cl.Text = dt.Tables[0].Rows[0]["REQ_PROV_USD_4MAS"].ToString();
                    else
                        tx_cl.Text = "0";

                if (CALIF_ACT == "1 - CPP")
                    //Requerimiento
                    if (selectedItem == "2 - Deficiente")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_1MAS"]).ToString();
                    else if (selectedItem == "3 - Dudoso")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_2MAS"]).ToString();
                    else if (selectedItem == "4 - Perdida")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_3MAS"]).ToString();
                    //Devolucion
                    else if (selectedItem == "0 - Normal")
                    tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_1MENOS"]).ToString();
                else
                    tx_cl.Text = "0";

                if (CALIF_ACT == "2 - Deficiente")
                    //Requerimiento
                    if (selectedItem == "3 - Dudoso")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_1MAS"]).ToString();
                    else if (selectedItem == "4 - Perdida")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_2MAS"]).ToString();
                    //Devolucion
                    else if (selectedItem == "1 - CPP")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_1MENOS"]).ToString();
                    else if (selectedItem == "0 - Normal")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_2MENOS"]).ToString();
                    else
                        tx_cl.Text = "0";



                if (CALIF_ACT == "3 - Dudoso")
                    //Requerimiento
                    if (selectedItem == "4 - Perdida")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["REQ_PROV_USD_1MAS"]).ToString();
                    //Devolucion
                    else if (selectedItem == "2 - Deficiente")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_1MENOS"]).ToString();
                    else if (selectedItem == "1 - CPP")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_2MENOS"]).ToString();
                    else if (selectedItem == "0 - Normal")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_3MENOS"]).ToString();
                    else
                        tx_cl.Text = "0";

                //Devolucion
                if (CALIF_ACT == "4 - Perdida")
                    if (selectedItem == "3 - Dudoso")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_1MENOS"]).ToString();
                    else if (selectedItem == "2 - Deficiente")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_2MENOS"]).ToString();
                    else if (selectedItem == "1 - CPP")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_3MENOS"]).ToString();
                    else if (selectedItem == "0 - Normal")
                        tx_cl.Text = String.Format("{0:n}", dt.Tables[0].Rows[0]["DEV_PROV_USD_4MENOS"]).ToString();
                    else
                        tx_cl.Text = "0";

            }

        }
    }
}
