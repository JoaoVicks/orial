namespace orial_bank
{
    partial class PixForm
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.inputKey = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PixType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2Button();
            this.inputValue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNext = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 30;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transferência PIX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.buttonNext);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.inputValue);
            this.guna2CustomGradientPanel1.Controls.Add(this.inputKey);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.PixType);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(28, 84);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(682, 274);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // inputKey
            // 
            this.inputKey.Location = new System.Drawing.Point(312, 41);
            this.inputKey.Name = "inputKey";
            this.inputKey.Palette = this.kryptonPalette2;
            this.inputKey.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.inputKey.Size = new System.Drawing.Size(340, 42);
            this.inputKey.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.inputKey.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputKey.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputKey.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputKey.StateCommon.Border.Rounding = 10;
            this.inputKey.StateCommon.Border.Width = 2;
            this.inputKey.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputKey.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputKey.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 5, 7);
            this.inputKey.TabIndex = 9;
            this.inputKey.Text = "digite o seu CPF ou CNPJ";
            this.inputKey.TextChanged += new System.EventHandler(this.inputKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(307, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chave :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PixType
            // 
            this.PixType.DropDownHeight = 220;
            this.PixType.DropDownWidth = 227;
            this.PixType.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.PixType.Items.AddRange(new object[] {
            "chave aleatória",
            "CPF",
            "email",
            "telefone"});
            this.PixType.Location = new System.Drawing.Point(43, 46);
            this.PixType.Name = "PixType";
            this.PixType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.PixType.Size = new System.Drawing.Size(233, 33);
            this.PixType.Sorted = true;
            this.PixType.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PixType.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.White;
            this.PixType.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.White;
            this.PixType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PixType.StateCommon.ComboBox.Border.Rounding = 10;
            this.PixType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.PixType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PixType.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(4);
            this.PixType.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PixType.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PixType.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PixType.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PixType.StateCommon.Item.Border.Color1 = System.Drawing.Color.White;
            this.PixType.StateCommon.Item.Border.Color2 = System.Drawing.Color.White;
            this.PixType.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PixType.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.White;
            this.PixType.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.White;
            this.PixType.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PixType.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.PixType.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.PixType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PixType.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.White;
            this.PixType.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.White;
            this.PixType.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.PixType.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.PixType.TabIndex = 7;
            this.PixType.Text = "tipo da chave pix";
            this.PixType.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            this.PixType.SelectedValueChanged += new System.EventHandler(this.PixType_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(39, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseForm.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCloseForm.Image = global::orial_bank.Properties.Resources.icn_cancel;
            this.btnCloseForm.ImageOffset = new System.Drawing.Point(-2, 2);
            this.btnCloseForm.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCloseForm.Location = new System.Drawing.Point(571, 19);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(114, 45);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.Text = "cancelar";
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // inputValue
            // 
            this.inputValue.Location = new System.Drawing.Point(43, 137);
            this.inputValue.Name = "inputValue";
            this.inputValue.Palette = this.kryptonPalette2;
            this.inputValue.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.inputValue.Size = new System.Drawing.Size(612, 42);
            this.inputValue.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.inputValue.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputValue.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputValue.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputValue.StateCommon.Border.Rounding = 10;
            this.inputValue.StateCommon.Border.Width = 2;
            this.inputValue.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValue.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 5, 7);
            this.inputValue.TabIndex = 10;
            this.inputValue.Text = "R$ :";
            this.inputValue.TextChanged += new System.EventHandler(this.inputValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Digite o valor para ser enviado :";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.buttonNext.BorderRadius = 10;
            this.buttonNext.BorderThickness = 2;
            this.buttonNext.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.buttonNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Image = global::orial_bank.Properties.Resources.arrow_right_white;
            this.buttonNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonNext.ImageSize = new System.Drawing.Size(13, 20);
            this.buttonNext.Location = new System.Drawing.Point(219, 204);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.PressedColor = System.Drawing.Color.Empty;
            this.buttonNext.Size = new System.Drawing.Size(205, 46);
            this.buttonNext.TabIndex = 14;
            this.buttonNext.Text = "efetuar pix";
            // 
            // PixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(735, 394);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PixForm";
            this.Palette = this.kryptonPalette2;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "t";
            this.Load += new System.EventHandler(this.PixForm_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox PixType;
        private Guna.UI2.WinForms.Guna2Button btnCloseForm;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox inputKey;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox inputValue;
        private Guna.UI2.WinForms.Guna2Button buttonNext;
    }
}