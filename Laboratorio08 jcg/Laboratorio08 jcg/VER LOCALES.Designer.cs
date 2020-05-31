namespace Laboratorio08_jcg
{
    partial class VER_LOCALES
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
            this.listBox_locales_activos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_atras_locales_activos = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_locales_activos
            // 
            this.listBox_locales_activos.FormattingEnabled = true;
            this.listBox_locales_activos.Location = new System.Drawing.Point(0, 86);
            this.listBox_locales_activos.Name = "listBox_locales_activos";
            this.listBox_locales_activos.Size = new System.Drawing.Size(797, 368);
            this.listBox_locales_activos.TabIndex = 0;
            this.listBox_locales_activos.SelectedIndexChanged += new System.EventHandler(this.listBox_locales_activos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOCALES ACTIVOS";
            // 
            // btn_atras_locales_activos
            // 
            this.btn_atras_locales_activos.BackColor = System.Drawing.Color.Gray;
            this.btn_atras_locales_activos.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras_locales_activos.Location = new System.Drawing.Point(669, 13);
            this.btn_atras_locales_activos.Name = "btn_atras_locales_activos";
            this.btn_atras_locales_activos.Size = new System.Drawing.Size(119, 58);
            this.btn_atras_locales_activos.TabIndex = 3;
            this.btn_atras_locales_activos.Text = "Atrás";
            this.btn_atras_locales_activos.UseVisualStyleBackColor = false;
            this.btn_atras_locales_activos.Click += new System.EventHandler(this.btn_atras_locales_activos_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.BackColor = System.Drawing.Color.Gray;
            this.btn_ver.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver.Location = new System.Drawing.Point(490, 13);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(119, 58);
            this.btn_ver.TabIndex = 4;
            this.btn_ver.Text = "Ver";
            this.btn_ver.UseVisualStyleBackColor = false;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // VER_LOCALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.btn_atras_locales_activos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_locales_activos);
            this.Name = "VER_LOCALES";
            this.Text = "VER_LOCALES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_locales_activos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_atras_locales_activos;
        private System.Windows.Forms.Button btn_ver;
    }
}