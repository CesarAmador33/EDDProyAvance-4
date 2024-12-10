
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminar1 = new System.Windows.Forms.Button();
            this.eliminar2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.recorrer = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.botonhoja = new System.Windows.Forms.Button();
            this.botonnodo = new System.Windows.Forms.Button();
            this.binariocompleto = new System.Windows.Forms.Button();
            this.binariolleno = new System.Windows.Forms.Button();
            this.texAltura = new System.Windows.Forms.TextBox();
            this.txtCantidadNodos = new System.Windows.Forms.TextBox();
            this.txtCantidadHojas = new System.Windows.Forms.TextBox();
            this.boton9 = new System.Windows.Forms.TextBox();
            this.boton10 = new System.Windows.Forms.TextBox();
            this.btrecorrer = new System.Windows.Forms.TextBox();
            this.txtDatoEliminar = new System.Windows.Forms.TextBox();
            this.btsucesor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(56, 20);
            this.txtDato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 31);
            this.txtDato.TabIndex = 0;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(139, 20);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(-25, 146);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(1649, 783);
            this.txtArbol.TabIndex = 2;
            this.txtArbol.TextChanged += new System.EventHandler(this.txtArbol_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(481, 25);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 30);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(247, 21);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(83, 30);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(356, 16);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(83, 39);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(8, 26);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(42, 16);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(139, 59);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 42);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(53, 66);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(80, 28);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(1184, 146);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(1103, 145);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(1103, 122);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(57, 16);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(1103, 102);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(1184, 122);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(54, 16);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "InOrden";
            this.lblRecorridoInOrden.Click += new System.EventHandler(this.lblRecorridoInOrden_Click);
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(1181, 102);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(65, 16);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PreOrden";
            this.lblRecorridoPreOrden.Click += new System.EventHandler(this.lblRecorridoPreOrden_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(863, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(723, 27);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(119, 22);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar nodo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eliminar1
            // 
            this.eliminar1.Location = new System.Drawing.Point(221, 116);
            this.eliminar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eliminar1.Name = "eliminar1";
            this.eliminar1.Size = new System.Drawing.Size(108, 42);
            this.eliminar1.TabIndex = 19;
            this.eliminar1.Text = "Eliminar nodo predecesor";
            this.eliminar1.UseVisualStyleBackColor = true;
            this.eliminar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminar2
            // 
            this.eliminar2.Location = new System.Drawing.Point(221, 172);
            this.eliminar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eliminar2.Name = "eliminar2";
            this.eliminar2.Size = new System.Drawing.Size(108, 44);
            this.eliminar2.TabIndex = 20;
            this.eliminar2.Text = "Eliminar sucesor";
            this.eliminar2.UseVisualStyleBackColor = true;
            this.eliminar2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(229, 64);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 46);
            this.button4.TabIndex = 22;
            this.button4.Text = "podar arbol";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // recorrer
            // 
            this.recorrer.Location = new System.Drawing.Point(481, 66);
            this.recorrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recorrer.Name = "recorrer";
            this.recorrer.Size = new System.Drawing.Size(109, 52);
            this.recorrer.TabIndex = 23;
            this.recorrer.Text = "Recorrer amplitud";
            this.recorrer.UseVisualStyleBackColor = true;
            this.recorrer.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(508, 145);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 46);
            this.button6.TabIndex = 24;
            this.button6.Text = "Obtener altura de arbol";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // botonhoja
            // 
            this.botonhoja.Location = new System.Drawing.Point(1107, 166);
            this.botonhoja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonhoja.Name = "botonhoja";
            this.botonhoja.Size = new System.Drawing.Size(101, 50);
            this.botonhoja.TabIndex = 25;
            this.botonhoja.Text = "Cantidad de hojas";
            this.botonhoja.UseVisualStyleBackColor = true;
            this.botonhoja.Click += new System.EventHandler(this.button7_Click);
            // 
            // botonnodo
            // 
            this.botonnodo.Location = new System.Drawing.Point(513, 196);
            this.botonnodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonnodo.Name = "botonnodo";
            this.botonnodo.Size = new System.Drawing.Size(109, 42);
            this.botonnodo.TabIndex = 26;
            this.botonnodo.Text = "boton nodo";
            this.botonnodo.UseVisualStyleBackColor = true;
            this.botonnodo.Click += new System.EventHandler(this.button8_Click);
            // 
            // binariocompleto
            // 
            this.binariocompleto.Location = new System.Drawing.Point(816, 145);
            this.binariocompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.binariocompleto.Name = "binariocompleto";
            this.binariocompleto.Size = new System.Drawing.Size(101, 46);
            this.binariocompleto.TabIndex = 27;
            this.binariocompleto.Text = "Binario completo";
            this.binariocompleto.UseVisualStyleBackColor = true;
            this.binariocompleto.Click += new System.EventHandler(this.button9_Click);
            // 
            // binariolleno
            // 
            this.binariolleno.Location = new System.Drawing.Point(816, 198);
            this.binariolleno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.binariolleno.Name = "binariolleno";
            this.binariolleno.Size = new System.Drawing.Size(119, 39);
            this.binariolleno.TabIndex = 28;
            this.binariolleno.Text = "Binario lleno";
            this.binariolleno.UseVisualStyleBackColor = true;
            this.binariolleno.Click += new System.EventHandler(this.button10_Click);
            // 
            // texAltura
            // 
            this.texAltura.Location = new System.Drawing.Point(644, 146);
            this.texAltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texAltura.Name = "texAltura";
            this.texAltura.Size = new System.Drawing.Size(132, 22);
            this.texAltura.TabIndex = 29;
            // 
            // txtCantidadNodos
            // 
            this.txtCantidadNodos.Location = new System.Drawing.Point(644, 213);
            this.txtCantidadNodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadNodos.Name = "txtCantidadNodos";
            this.txtCantidadNodos.Size = new System.Drawing.Size(132, 22);
            this.txtCantidadNodos.TabIndex = 30;
            this.txtCantidadNodos.TextChanged += new System.EventHandler(this.txtCantidadNodos_TextChanged);
            // 
            // txtCantidadHojas
            // 
            this.txtCantidadHojas.Location = new System.Drawing.Point(1216, 180);
            this.txtCantidadHojas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadHojas.Name = "txtCantidadHojas";
            this.txtCantidadHojas.Size = new System.Drawing.Size(132, 22);
            this.txtCantidadHojas.TabIndex = 31;
            // 
            // boton9
            // 
            this.boton9.Location = new System.Drawing.Point(943, 156);
            this.boton9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(132, 22);
            this.boton9.TabIndex = 32;
            // 
            // boton10
            // 
            this.boton10.Location = new System.Drawing.Point(943, 206);
            this.boton10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boton10.Name = "boton10";
            this.boton10.Size = new System.Drawing.Size(132, 22);
            this.boton10.TabIndex = 33;
            // 
            // btrecorrer
            // 
            this.btrecorrer.Location = new System.Drawing.Point(599, 78);
            this.btrecorrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btrecorrer.Name = "btrecorrer";
            this.btrecorrer.Size = new System.Drawing.Size(427, 22);
            this.btrecorrer.TabIndex = 34;
            this.btrecorrer.TextChanged += new System.EventHandler(this.btrecorrer_TextChanged);
            // 
            // txtDatoEliminar
            // 
            this.txtDatoEliminar.Location = new System.Drawing.Point(337, 113);
            this.txtDatoEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatoEliminar.Name = "txtDatoEliminar";
            this.txtDatoEliminar.Size = new System.Drawing.Size(115, 22);
            this.txtDatoEliminar.TabIndex = 36;
            // 
            // btsucesor
            // 
            this.btsucesor.Location = new System.Drawing.Point(337, 183);
            this.btsucesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsucesor.Name = "btsucesor";
            this.btsucesor.Size = new System.Drawing.Size(132, 22);
            this.btsucesor.TabIndex = 37;
            this.btsucesor.TextChanged += new System.EventHandler(this.sucesor_TextChanged);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 892);
            this.Controls.Add(this.btsucesor);
            this.Controls.Add(this.txtDatoEliminar);
            this.Controls.Add(this.btrecorrer);
            this.Controls.Add(this.boton10);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.txtCantidadHojas);
            this.Controls.Add(this.txtCantidadNodos);
            this.Controls.Add(this.texAltura);
            this.Controls.Add(this.binariolleno);
            this.Controls.Add(this.binariocompleto);
            this.Controls.Add(this.botonnodo);
            this.Controls.Add(this.botonhoja);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.recorrer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.eliminar2);
            this.Controls.Add(this.eliminar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminar1;
        private System.Windows.Forms.Button eliminar2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button recorrer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button botonhoja;
        private System.Windows.Forms.Button botonnodo;
        private System.Windows.Forms.Button binariocompleto;
        private System.Windows.Forms.Button binariolleno;
        private System.Windows.Forms.TextBox texAltura;
        private System.Windows.Forms.TextBox txtCantidadNodos;
        private System.Windows.Forms.TextBox txtCantidadHojas;
        private System.Windows.Forms.TextBox boton9;
        private System.Windows.Forms.TextBox boton10;
        private System.Windows.Forms.TextBox btrecorrer;
        private System.Windows.Forms.TextBox txtDatoEliminar;
        private System.Windows.Forms.TextBox btsucesor;
    }
}