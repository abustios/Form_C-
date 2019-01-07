namespace WX_PROV_CONSULTACLASIF
{
    partial class Form_CLASIF_PROV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_tipdoc = new System.Windows.Forms.ComboBox();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.BTN_CONSULTA = new System.Windows.Forms.Button();
            this.LB_NOMBRE = new System.Windows.Forms.Label();
            this.lb_clasif = new System.Windows.Forms.Label();
            this.lb_ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_DEUDATOTAL = new System.Windows.Forms.TextBox();
            this.TX_DEUDATOTALFCC = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tx_cl = new System.Windows.Forms.TextBox();
            this.lbl_td = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Dev_Req = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_tipdoc
            // 
            this.cb_tipdoc.FormattingEnabled = true;
            this.cb_tipdoc.Items.AddRange(new object[] {
            "IBS",
            "DNI",
            "RUC"});
            this.cb_tipdoc.Location = new System.Drawing.Point(47, 31);
            this.cb_tipdoc.Name = "cb_tipdoc";
            this.cb_tipdoc.Size = new System.Drawing.Size(121, 21);
            this.cb_tipdoc.TabIndex = 0;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(191, 32);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(100, 20);
            this.txt_documento.TabIndex = 1;
            // 
            // BTN_CONSULTA
            // 
            this.BTN_CONSULTA.Location = new System.Drawing.Point(341, 30);
            this.BTN_CONSULTA.Name = "BTN_CONSULTA";
            this.BTN_CONSULTA.Size = new System.Drawing.Size(75, 23);
            this.BTN_CONSULTA.TabIndex = 2;
            this.BTN_CONSULTA.Text = "Consulta";
            this.BTN_CONSULTA.UseVisualStyleBackColor = true;
            this.BTN_CONSULTA.Click += new System.EventHandler(this.BTN_CONSULTA_Click);
            // 
            // LB_NOMBRE
            // 
            this.LB_NOMBRE.AutoSize = true;
            this.LB_NOMBRE.Location = new System.Drawing.Point(44, 67);
            this.LB_NOMBRE.Name = "LB_NOMBRE";
            this.LB_NOMBRE.Size = new System.Drawing.Size(50, 13);
            this.LB_NOMBRE.TabIndex = 4;
            this.LB_NOMBRE.Text = "Nombre: ";
            // 
            // lb_clasif
            // 
            this.lb_clasif.AutoSize = true;
            this.lb_clasif.Location = new System.Drawing.Point(44, 95);
            this.lb_clasif.Name = "lb_clasif";
            this.lb_clasif.Size = new System.Drawing.Size(72, 13);
            this.lb_clasif.TabIndex = 5;
            this.lb_clasif.Text = "Clasificación: ";
            // 
            // lb_
            // 
            this.lb_.AutoSize = true;
            this.lb_.Location = new System.Drawing.Point(47, 133);
            this.lb_.Name = "lb_";
            this.lb_.Size = new System.Drawing.Size(81, 13);
            this.lb_.TabIndex = 7;
            this.lb_.Text = "Deuda Total $: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deuda Total FCC $: ";
            // 
            // TX_DEUDATOTAL
            // 
            this.TX_DEUDATOTAL.Location = new System.Drawing.Point(147, 130);
            this.TX_DEUDATOTAL.Name = "TX_DEUDATOTAL";
            this.TX_DEUDATOTAL.ReadOnly = true;
            this.TX_DEUDATOTAL.Size = new System.Drawing.Size(100, 20);
            this.TX_DEUDATOTAL.TabIndex = 9;
            // 
            // TX_DEUDATOTALFCC
            // 
            this.TX_DEUDATOTALFCC.Location = new System.Drawing.Point(147, 160);
            this.TX_DEUDATOTALFCC.Name = "TX_DEUDATOTALFCC";
            this.TX_DEUDATOTALFCC.ReadOnly = true;
            this.TX_DEUDATOTALFCC.Size = new System.Drawing.Size(100, 20);
            this.TX_DEUDATOTALFCC.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0 - Normal",
            "1 - CPP",
            "2 - Deficiente",
            "3 - Dudoso",
            "4 - Perdida"});
            this.comboBox1.Location = new System.Drawing.Point(47, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tx_cl
            // 
            this.tx_cl.Location = new System.Drawing.Point(191, 265);
            this.tx_cl.Name = "tx_cl";
            this.tx_cl.Size = new System.Drawing.Size(100, 20);
            this.tx_cl.TabIndex = 12;
            // 
            // lbl_td
            // 
            this.lbl_td.AutoSize = true;
            this.lbl_td.Location = new System.Drawing.Point(47, 13);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(86, 13);
            this.lbl_td.TabIndex = 13;
            this.lbl_td.Text = "Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seleccionar Clasificación";
            // 
            // lb_Dev_Req
            // 
            this.lb_Dev_Req.AutoSize = true;
            this.lb_Dev_Req.Location = new System.Drawing.Point(47, 268);
            this.lb_Dev_Req.Name = "lb_Dev_Req";
            this.lb_Dev_Req.Size = new System.Drawing.Size(0, 13);
            this.lb_Dev_Req.TabIndex = 16;
            // 
            // Form_CLASIF_PROV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 502);
            this.Controls.Add(this.lb_Dev_Req);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_td);
            this.Controls.Add(this.tx_cl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TX_DEUDATOTALFCC);
            this.Controls.Add(this.TX_DEUDATOTAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_);
            this.Controls.Add(this.lb_clasif);
            this.Controls.Add(this.LB_NOMBRE);
            this.Controls.Add(this.BTN_CONSULTA);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.cb_tipdoc);
            this.Name = "Form_CLASIF_PROV";
            this.Text = "Form_CLASIF_PROV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tipdoc;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.Button BTN_CONSULTA;
        private System.Windows.Forms.Label LB_NOMBRE;
        private System.Windows.Forms.Label lb_clasif;
        private System.Windows.Forms.Label lb_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TX_DEUDATOTAL;
        private System.Windows.Forms.TextBox TX_DEUDATOTALFCC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tx_cl;
        private System.Windows.Forms.Label lbl_td;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Dev_Req;
    }
}