namespace orial_bank
{
    partial class RegisterWindow
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonNext = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.inputEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonMaskedTextBox3 = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kryptonMaskedTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonMaskedTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.inputCreateCPF = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.buttonNext);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.inputEmail);
            this.guna2Panel1.Controls.Add(this.kryptonMaskedTextBox3);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.kryptonMaskedTextBox2);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.kryptonMaskedTextBox1);
            this.guna2Panel1.Controls.Add(this.inputCreateCPF);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.inputName);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.guna2Panel1.Location = new System.Drawing.Point(22, 82);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(480, 565);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // buttonNext
            // 
            this.buttonNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.buttonNext.BorderRadius = 10;
            this.buttonNext.BorderThickness = 2;
            this.buttonNext.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.buttonNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNext.FillColor = System.Drawing.Color.Transparent;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.buttonNext.Image = global::orial_bank.Properties.Resources.arrow_right;
            this.buttonNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonNext.ImageSize = new System.Drawing.Size(13, 20);
            this.buttonNext.Location = new System.Drawing.Point(303, 495);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.PressedColor = System.Drawing.Color.Empty;
            this.buttonNext.Size = new System.Drawing.Size(155, 46);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "avançar";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(32, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "E-mail :";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(31, 416);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Palette = this.kryptonPalette2;
            this.inputEmail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.inputEmail.Size = new System.Drawing.Size(427, 42);
            this.inputEmail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.inputEmail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputEmail.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputEmail.StateCommon.Border.Rounding = 10;
            this.inputEmail.StateCommon.Border.Width = 2;
            this.inputEmail.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputEmail.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 5, 7);
            this.inputEmail.TabIndex = 11;
            this.inputEmail.Text = "digite o seu email";
            this.inputEmail.UseMnemonic = false;
            this.inputEmail.TextChanged += new System.EventHandler(this.inputEmail_TextChanged);
            this.inputEmail.Enter += new System.EventHandler(this.inputEmail_Enter);
            this.inputEmail.Leave += new System.EventHandler(this.inputEmail_Leave);
            // 
            // kryptonMaskedTextBox3
            // 
            this.kryptonMaskedTextBox3.Location = new System.Drawing.Point(222, 335);
            this.kryptonMaskedTextBox3.Mask = "(99) 99999-9999";
            this.kryptonMaskedTextBox3.Name = "kryptonMaskedTextBox3";
            this.kryptonMaskedTextBox3.Size = new System.Drawing.Size(233, 40);
            this.kryptonMaskedTextBox3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.kryptonMaskedTextBox3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonMaskedTextBox3.StateCommon.Border.Rounding = 10;
            this.kryptonMaskedTextBox3.StateCommon.Border.Width = 2;
            this.kryptonMaskedTextBox3.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox3.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kryptonMaskedTextBox3.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 5, 7);
            this.kryptonMaskedTextBox3.TabIndex = 10;
            this.kryptonMaskedTextBox3.Text = "(  )      -";
            this.kryptonMaskedTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.kryptonMaskedTextBox3_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(220, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Telefone :";
            // 
            // kryptonMaskedTextBox2
            // 
            this.kryptonMaskedTextBox2.Location = new System.Drawing.Point(28, 335);
            this.kryptonMaskedTextBox2.Mask = "99/99/9999";
            this.kryptonMaskedTextBox2.Name = "kryptonMaskedTextBox2";
            this.kryptonMaskedTextBox2.Size = new System.Drawing.Size(178, 40);
            this.kryptonMaskedTextBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.kryptonMaskedTextBox2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonMaskedTextBox2.StateCommon.Border.Rounding = 10;
            this.kryptonMaskedTextBox2.StateCommon.Border.Width = 2;
            this.kryptonMaskedTextBox2.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kryptonMaskedTextBox2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 5, 7);
            this.kryptonMaskedTextBox2.TabIndex = 8;
            this.kryptonMaskedTextBox2.Text = "  /  /";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(26, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data de nascimento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(26, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG :";
            // 
            // kryptonMaskedTextBox1
            // 
            this.kryptonMaskedTextBox1.Location = new System.Drawing.Point(28, 248);
            this.kryptonMaskedTextBox1.Mask = "99,999,999,-9";
            this.kryptonMaskedTextBox1.Name = "kryptonMaskedTextBox1";
            this.kryptonMaskedTextBox1.Size = new System.Drawing.Size(427, 40);
            this.kryptonMaskedTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.kryptonMaskedTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonMaskedTextBox1.StateCommon.Border.Rounding = 10;
            this.kryptonMaskedTextBox1.StateCommon.Border.Width = 2;
            this.kryptonMaskedTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.kryptonMaskedTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kryptonMaskedTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 5, 7);
            this.kryptonMaskedTextBox1.TabIndex = 5;
            this.kryptonMaskedTextBox1.Text = "  .   .   .-";
            // 
            // inputCreateCPF
            // 
            this.inputCreateCPF.Location = new System.Drawing.Point(28, 80);
            this.inputCreateCPF.Name = "inputCreateCPF";
            this.inputCreateCPF.Palette = this.kryptonPalette2;
            this.inputCreateCPF.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.inputCreateCPF.Size = new System.Drawing.Size(427, 42);
            this.inputCreateCPF.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.inputCreateCPF.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputCreateCPF.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputCreateCPF.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputCreateCPF.StateCommon.Border.Rounding = 10;
            this.inputCreateCPF.StateCommon.Border.Width = 2;
            this.inputCreateCPF.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputCreateCPF.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreateCPF.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 5, 7);
            this.inputCreateCPF.TabIndex = 4;
            this.inputCreateCPF.Text = "digite o seu CPF ou CNPJ";
            this.inputCreateCPF.TextChanged += new System.EventHandler(this.inputCreateCPF_TextChanged);
            this.inputCreateCPF.Enter += new System.EventHandler(this.inputCreateCPF_Enter);
            this.inputCreateCPF.Leave += new System.EventHandler(this.inputCreateCPF_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF/CNPJ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(28, 162);
            this.inputName.Name = "inputName";
            this.inputName.Palette = this.kryptonPalette2;
            this.inputName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.inputName.Size = new System.Drawing.Size(427, 42);
            this.inputName.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.inputName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputName.StateCommon.Border.Rounding = 10;
            this.inputName.StateCommon.Border.Width = 2;
            this.inputName.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 5, 7);
            this.inputName.TabIndex = 1;
            this.inputName.Text = "digite o seu nome";
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            this.inputName.Enter += new System.EventHandler(this.inputName_Enter);
            this.inputName.Leave += new System.EventHandler(this.inputName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(380, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "passo 1 de 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(193, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btnCloseForm.Location = new System.Drawing.Point(28, 19);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(114, 45);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "cancelar";
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // RegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(524, 668);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterWindow";
            this.Palette = this.kryptonPalette2;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.Text = "RegisterWindow";
            this.Load += new System.EventHandler(this.RegisterWindow_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCloseForm;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox inputName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox inputCreateCPF;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox2;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox inputEmail;
        private Guna.UI2.WinForms.Guna2Button buttonNext;
    }
}