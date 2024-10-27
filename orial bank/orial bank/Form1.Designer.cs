namespace orial_bank
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.inputPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSeeOrHidden = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.inputCPF = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.buttonCreateAccount = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::orial_bank.Properties.Resources.closeform_button;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageNormal = global::orial_bank.Properties.Resources.closeform_button;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::orial_bank.Properties.Resources.closeform_button;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::orial_bank.Properties.Resources.closeform_button;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::orial_bank.Properties.Resources.expandirform_button;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageNormal = global::orial_bank.Properties.Resources.expandirform_button;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::orial_bank.Properties.Resources.expandirform_button;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::orial_bank.Properties.Resources.expandirform_button;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::orial_bank.Properties.Resources.minform_button;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageNormal = global::orial_bank.Properties.Resources.minform_button;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::orial_bank.Properties.Resources.minform_button;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::orial_bank.Properties.Resources.minform_button;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Image = global::orial_bank.Properties.Resources.Design_sem_nome;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Image = global::orial_bank.Properties.Resources.Design_sem_nome;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 20;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(3);
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(82, 224);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(293, 41);
            this.inputPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputPassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.inputPassword.StateCommon.Border.Rounding = 12;
            this.inputPassword.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.inputPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.inputPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 6, 5, 6);
            this.inputPassword.TabIndex = 0;
            this.inputPassword.Text = "digite sua senha";
            this.inputPassword.TextChanged += new System.EventHandler(this.inputPassword_TextChanged);
            this.inputPassword.Enter += new System.EventHandler(this.inputPassword_Enter);
            this.inputPassword.Leave += new System.EventHandler(this.inputPassword_Leave);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(32, 288);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Palette = this.kryptonPalette1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(343, 48);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 12;
            this.kryptonButton1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, 5);
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "entrar na conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 68.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 120);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 68.25F);
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(219, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 120);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1100, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "o melhor banco para o seu bolso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(39, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "O melhor banco para o seu bolso";
            // 
            // checkBoxSeeOrHidden
            // 
            this.checkBoxSeeOrHidden.Location = new System.Drawing.Point(32, 224);
            this.checkBoxSeeOrHidden.Name = "checkBoxSeeOrHidden";
            this.checkBoxSeeOrHidden.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.checkBoxSeeOrHidden.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.checkBoxSeeOrHidden.OverrideDefault.Back.Image = global::orial_bank.Properties.Resources.close_eye;
            this.checkBoxSeeOrHidden.OverrideDefault.Border.Color1 = System.Drawing.Color.MediumSpringGreen;
            this.checkBoxSeeOrHidden.OverrideDefault.Border.Color2 = System.Drawing.Color.MediumSpringGreen;
            this.checkBoxSeeOrHidden.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkBoxSeeOrHidden.OverrideDefault.Border.Rounding = 5;
            this.checkBoxSeeOrHidden.OverrideDefault.Border.Width = 2;
            this.checkBoxSeeOrHidden.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkBoxSeeOrHidden.Palette = this.kryptonPalette1;
            this.checkBoxSeeOrHidden.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.checkBoxSeeOrHidden.Size = new System.Drawing.Size(44, 41);
            this.checkBoxSeeOrHidden.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.checkBoxSeeOrHidden.StateCheckedNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.checkBoxSeeOrHidden.StateCheckedNormal.Back.Image = global::orial_bank.Properties.Resources.open_eye;
            this.checkBoxSeeOrHidden.StateCheckedNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.checkBoxSeeOrHidden.StateCheckedNormal.Border.Color1 = System.Drawing.Color.MediumSpringGreen;
            this.checkBoxSeeOrHidden.StateCheckedNormal.Border.Color2 = System.Drawing.Color.MediumSpringGreen;
            this.checkBoxSeeOrHidden.StateCheckedNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkBoxSeeOrHidden.StateCheckedNormal.Border.Rounding = 5;
            this.checkBoxSeeOrHidden.StateCheckedNormal.Border.Width = 2;
            this.checkBoxSeeOrHidden.StateCheckedPressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.checkBoxSeeOrHidden.StateCheckedPressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.checkBoxSeeOrHidden.StateCheckedPressed.Back.Image = global::orial_bank.Properties.Resources.open_eye;
            this.checkBoxSeeOrHidden.StateCheckedPressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.checkBoxSeeOrHidden.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.checkBoxSeeOrHidden.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.checkBoxSeeOrHidden.StateNormal.Back.Image = global::orial_bank.Properties.Resources.close_eye;
            this.checkBoxSeeOrHidden.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.checkBoxSeeOrHidden.StateNormal.Border.Color1 = System.Drawing.Color.MediumSpringGreen;
            this.checkBoxSeeOrHidden.StateNormal.Border.Color2 = System.Drawing.Color.MediumSpringGreen;
            this.checkBoxSeeOrHidden.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkBoxSeeOrHidden.StateNormal.Border.Rounding = 12;
            this.checkBoxSeeOrHidden.StateNormal.Border.Width = 2;
            this.checkBoxSeeOrHidden.TabIndex = 6;
            this.checkBoxSeeOrHidden.Values.Text = "";
            this.checkBoxSeeOrHidden.CheckedChanged += new System.EventHandler(this.checkBoxSeeOrHidden_CheckedChanged);
            this.checkBoxSeeOrHidden.Click += new System.EventHandler(this.checkBoxSeeOrHidden_Click);
            // 
            // inputCPF
            // 
            this.inputCPF.Location = new System.Drawing.Point(32, 158);
            this.inputCPF.Mask = "999 , 999 , 999 --99";
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.Size = new System.Drawing.Size(343, 42);
            this.inputCPF.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.inputCPF.StateCommon.Border.Rounding = 12;
            this.inputCPF.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.inputCPF.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 6, 5, 6);
            this.inputCPF.TabIndex = 8;
            this.inputCPF.Text = "    .     .     --";
            this.inputCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.inputCPF_MaskInputRejected);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(20, 344);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(370, 27);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.StateCommon.Image = global::orial_bank.Properties.Resources.division_line2;
            this.kryptonPanel1.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonPanel1.TabIndex = 9;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(32, 387);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Palette = this.kryptonPalette1;
            this.buttonCreateAccount.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonCreateAccount.Size = new System.Drawing.Size(343, 48);
            this.buttonCreateAccount.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.buttonCreateAccount.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.buttonCreateAccount.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonCreateAccount.StateCommon.Border.Rounding = 12;
            this.buttonCreateAccount.StateCommon.Border.Width = 3;
            this.buttonCreateAccount.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, 5);
            this.buttonCreateAccount.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.buttonCreateAccount.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(79)))));
            this.buttonCreateAccount.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.TabIndex = 10;
            this.buttonCreateAccount.Values.Text = "criar conta";
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::orial_bank.Properties.Resources.Design_sem_nome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 533);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.inputCPF);
            this.Controls.Add(this.checkBoxSeeOrHidden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.inputPassword);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox inputPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton checkBoxSeeOrHidden;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox inputCPF;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonCreateAccount;
    }
}

