namespace ObjViewer
{
    partial class frmObjViewer
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
            this.glControlMain = new OpenTK.GLControl();
            this.chkInvertMouseWheel = new System.Windows.Forms.CheckBox();
            this.grpMouseWheelSensitivity = new System.Windows.Forms.GroupBox();
            this.rbHighSensitivityWheel = new System.Windows.Forms.RadioButton();
            this.rbLowSensitivityWheel = new System.Windows.Forms.RadioButton();
            this.rbMediumSensitivityWheel = new System.Windows.Forms.RadioButton();
            this.chkInvertMouse = new System.Windows.Forms.CheckBox();
            this.grpMouseOptions = new System.Windows.Forms.GroupBox();
            this.rbHighSensitivity = new System.Windows.Forms.RadioButton();
            this.rbMediumSensitivity = new System.Windows.Forms.RadioButton();
            this.rbLowSensitivity = new System.Windows.Forms.RadioButton();
            this.btnResetView = new System.Windows.Forms.Button();
            this.grpAutoRotate = new System.Windows.Forms.GroupBox();
            this.rbARHighSpeed = new System.Windows.Forms.RadioButton();
            this.chkAutoRotate = new System.Windows.Forms.CheckBox();
            this.rbARLowSpeed = new System.Windows.Forms.RadioButton();
            this.rbARMediumSpeed = new System.Windows.Forms.RadioButton();
            this.btnLoadObj = new System.Windows.Forms.Button();
            this.btnLoadTexture = new System.Windows.Forms.Button();
            this.lblZRotation = new System.Windows.Forms.Label();
            this.nUDZRotation = new System.Windows.Forms.NumericUpDown();
            this.lblXRotation = new System.Windows.Forms.Label();
            this.lblYRotation = new System.Windows.Forms.Label();
            this.nUDXRotation = new System.Windows.Forms.NumericUpDown();
            this.nUDYRotation = new System.Windows.Forms.NumericUpDown();
            this.grpTexture = new System.Windows.Forms.GroupBox();
            this.cmbTextureMethod = new System.Windows.Forms.ComboBox();
            this.lblTextureMethod = new System.Windows.Forms.Label();
            this.grpMouseWheelSensitivity.SuspendLayout();
            this.grpMouseOptions.SuspendLayout();
            this.grpAutoRotate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDZRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYRotation)).BeginInit();
            this.grpTexture.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControlMain
            // 
            this.glControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControlMain.BackColor = System.Drawing.Color.Transparent;
            this.glControlMain.ForeColor = System.Drawing.Color.Transparent;
            this.glControlMain.Location = new System.Drawing.Point(12, 12);
            this.glControlMain.Name = "glControlMain";
            this.glControlMain.Size = new System.Drawing.Size(1407, 738);
            this.glControlMain.TabIndex = 1;
            this.glControlMain.VSync = false;
            // 
            // chkInvertMouseWheel
            // 
            this.chkInvertMouseWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInvertMouseWheel.AutoSize = true;
            this.chkInvertMouseWheel.Location = new System.Drawing.Point(6, 19);
            this.chkInvertMouseWheel.Name = "chkInvertMouseWheel";
            this.chkInvertMouseWheel.Size = new System.Drawing.Size(122, 17);
            this.chkInvertMouseWheel.TabIndex = 3;
            this.chkInvertMouseWheel.Text = "Invert Mouse Wheel";
            this.chkInvertMouseWheel.UseVisualStyleBackColor = true;
            // 
            // grpMouseWheelSensitivity
            // 
            this.grpMouseWheelSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMouseWheelSensitivity.Controls.Add(this.rbHighSensitivityWheel);
            this.grpMouseWheelSensitivity.Controls.Add(this.chkInvertMouseWheel);
            this.grpMouseWheelSensitivity.Controls.Add(this.rbLowSensitivityWheel);
            this.grpMouseWheelSensitivity.Controls.Add(this.rbMediumSensitivityWheel);
            this.grpMouseWheelSensitivity.Location = new System.Drawing.Point(1425, 249);
            this.grpMouseWheelSensitivity.Name = "grpMouseWheelSensitivity";
            this.grpMouseWheelSensitivity.Size = new System.Drawing.Size(141, 120);
            this.grpMouseWheelSensitivity.TabIndex = 4;
            this.grpMouseWheelSensitivity.TabStop = false;
            this.grpMouseWheelSensitivity.Text = "Mouse Wheel Options";
            // 
            // rbHighSensitivityWheel
            // 
            this.rbHighSensitivityWheel.AutoSize = true;
            this.rbHighSensitivityWheel.Location = new System.Drawing.Point(6, 88);
            this.rbHighSensitivityWheel.Name = "rbHighSensitivityWheel";
            this.rbHighSensitivityWheel.Size = new System.Drawing.Size(97, 17);
            this.rbHighSensitivityWheel.TabIndex = 0;
            this.rbHighSensitivityWheel.TabStop = true;
            this.rbHighSensitivityWheel.Text = "High Sensitivity";
            this.rbHighSensitivityWheel.UseVisualStyleBackColor = true;
            // 
            // rbLowSensitivityWheel
            // 
            this.rbLowSensitivityWheel.AutoSize = true;
            this.rbLowSensitivityWheel.Location = new System.Drawing.Point(6, 42);
            this.rbLowSensitivityWheel.Name = "rbLowSensitivityWheel";
            this.rbLowSensitivityWheel.Size = new System.Drawing.Size(95, 17);
            this.rbLowSensitivityWheel.TabIndex = 0;
            this.rbLowSensitivityWheel.TabStop = true;
            this.rbLowSensitivityWheel.Text = "Low Sensitivity";
            this.rbLowSensitivityWheel.UseVisualStyleBackColor = true;
            // 
            // rbMediumSensitivityWheel
            // 
            this.rbMediumSensitivityWheel.AutoSize = true;
            this.rbMediumSensitivityWheel.Location = new System.Drawing.Point(6, 65);
            this.rbMediumSensitivityWheel.Name = "rbMediumSensitivityWheel";
            this.rbMediumSensitivityWheel.Size = new System.Drawing.Size(112, 17);
            this.rbMediumSensitivityWheel.TabIndex = 0;
            this.rbMediumSensitivityWheel.TabStop = true;
            this.rbMediumSensitivityWheel.Text = "Medium Sensitivity";
            this.rbMediumSensitivityWheel.UseVisualStyleBackColor = true;
            // 
            // chkInvertMouse
            // 
            this.chkInvertMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInvertMouse.AutoSize = true;
            this.chkInvertMouse.Location = new System.Drawing.Point(6, 19);
            this.chkInvertMouse.Name = "chkInvertMouse";
            this.chkInvertMouse.Size = new System.Drawing.Size(88, 17);
            this.chkInvertMouse.TabIndex = 3;
            this.chkInvertMouse.Text = "Invert Mouse";
            this.chkInvertMouse.UseVisualStyleBackColor = true;
            // 
            // grpMouseOptions
            // 
            this.grpMouseOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMouseOptions.Controls.Add(this.rbHighSensitivity);
            this.grpMouseOptions.Controls.Add(this.rbMediumSensitivity);
            this.grpMouseOptions.Controls.Add(this.chkInvertMouse);
            this.grpMouseOptions.Controls.Add(this.rbLowSensitivity);
            this.grpMouseOptions.Location = new System.Drawing.Point(1425, 123);
            this.grpMouseOptions.Name = "grpMouseOptions";
            this.grpMouseOptions.Size = new System.Drawing.Size(141, 120);
            this.grpMouseOptions.TabIndex = 4;
            this.grpMouseOptions.TabStop = false;
            this.grpMouseOptions.Text = "Mouse Rotation Options";
            // 
            // rbHighSensitivity
            // 
            this.rbHighSensitivity.AutoSize = true;
            this.rbHighSensitivity.Location = new System.Drawing.Point(6, 88);
            this.rbHighSensitivity.Name = "rbHighSensitivity";
            this.rbHighSensitivity.Size = new System.Drawing.Size(97, 17);
            this.rbHighSensitivity.TabIndex = 0;
            this.rbHighSensitivity.TabStop = true;
            this.rbHighSensitivity.Text = "High Sensitivity";
            this.rbHighSensitivity.UseVisualStyleBackColor = true;
            // 
            // rbMediumSensitivity
            // 
            this.rbMediumSensitivity.AutoSize = true;
            this.rbMediumSensitivity.Location = new System.Drawing.Point(6, 65);
            this.rbMediumSensitivity.Name = "rbMediumSensitivity";
            this.rbMediumSensitivity.Size = new System.Drawing.Size(112, 17);
            this.rbMediumSensitivity.TabIndex = 0;
            this.rbMediumSensitivity.TabStop = true;
            this.rbMediumSensitivity.Text = "Medium Sensitivity";
            this.rbMediumSensitivity.UseVisualStyleBackColor = true;
            // 
            // rbLowSensitivity
            // 
            this.rbLowSensitivity.AutoSize = true;
            this.rbLowSensitivity.Location = new System.Drawing.Point(6, 42);
            this.rbLowSensitivity.Name = "rbLowSensitivity";
            this.rbLowSensitivity.Size = new System.Drawing.Size(95, 17);
            this.rbLowSensitivity.TabIndex = 0;
            this.rbLowSensitivity.TabStop = true;
            this.rbLowSensitivity.Text = "Low Sensitivity";
            this.rbLowSensitivity.UseVisualStyleBackColor = true;
            // 
            // btnResetView
            // 
            this.btnResetView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetView.Location = new System.Drawing.Point(1425, 502);
            this.btnResetView.Name = "btnResetView";
            this.btnResetView.Size = new System.Drawing.Size(141, 23);
            this.btnResetView.TabIndex = 5;
            this.btnResetView.Text = "Reset View";
            this.btnResetView.UseVisualStyleBackColor = true;
            // 
            // grpAutoRotate
            // 
            this.grpAutoRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAutoRotate.Controls.Add(this.rbARHighSpeed);
            this.grpAutoRotate.Controls.Add(this.chkAutoRotate);
            this.grpAutoRotate.Controls.Add(this.rbARLowSpeed);
            this.grpAutoRotate.Controls.Add(this.rbARMediumSpeed);
            this.grpAutoRotate.Location = new System.Drawing.Point(1426, 376);
            this.grpAutoRotate.Name = "grpAutoRotate";
            this.grpAutoRotate.Size = new System.Drawing.Size(140, 120);
            this.grpAutoRotate.TabIndex = 7;
            this.grpAutoRotate.TabStop = false;
            this.grpAutoRotate.Text = "Auto Rotate";
            // 
            // rbARHighSpeed
            // 
            this.rbARHighSpeed.AutoSize = true;
            this.rbARHighSpeed.Location = new System.Drawing.Point(5, 92);
            this.rbARHighSpeed.Name = "rbARHighSpeed";
            this.rbARHighSpeed.Size = new System.Drawing.Size(81, 17);
            this.rbARHighSpeed.TabIndex = 0;
            this.rbARHighSpeed.TabStop = true;
            this.rbARHighSpeed.Text = "High Speed";
            this.rbARHighSpeed.UseVisualStyleBackColor = true;
            // 
            // chkAutoRotate
            // 
            this.chkAutoRotate.Location = new System.Drawing.Point(7, 20);
            this.chkAutoRotate.Name = "chkAutoRotate";
            this.chkAutoRotate.Size = new System.Drawing.Size(127, 20);
            this.chkAutoRotate.TabIndex = 0;
            this.chkAutoRotate.Text = "Auto Rotate";
            this.chkAutoRotate.UseVisualStyleBackColor = true;
            // 
            // rbARLowSpeed
            // 
            this.rbARLowSpeed.AutoSize = true;
            this.rbARLowSpeed.Location = new System.Drawing.Point(5, 46);
            this.rbARLowSpeed.Name = "rbARLowSpeed";
            this.rbARLowSpeed.Size = new System.Drawing.Size(79, 17);
            this.rbARLowSpeed.TabIndex = 0;
            this.rbARLowSpeed.TabStop = true;
            this.rbARLowSpeed.Text = "Low Speed";
            this.rbARLowSpeed.UseVisualStyleBackColor = true;
            // 
            // rbARMediumSpeed
            // 
            this.rbARMediumSpeed.AutoSize = true;
            this.rbARMediumSpeed.Location = new System.Drawing.Point(5, 69);
            this.rbARMediumSpeed.Name = "rbARMediumSpeed";
            this.rbARMediumSpeed.Size = new System.Drawing.Size(96, 17);
            this.rbARMediumSpeed.TabIndex = 0;
            this.rbARMediumSpeed.TabStop = true;
            this.rbARMediumSpeed.Text = "Medium Speed";
            this.rbARMediumSpeed.UseVisualStyleBackColor = true;
            // 
            // btnLoadObj
            // 
            this.btnLoadObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadObj.Location = new System.Drawing.Point(1425, 12);
            this.btnLoadObj.Name = "btnLoadObj";
            this.btnLoadObj.Size = new System.Drawing.Size(141, 23);
            this.btnLoadObj.TabIndex = 8;
            this.btnLoadObj.Text = "Load .Obj File";
            this.btnLoadObj.UseVisualStyleBackColor = true;
            // 
            // btnLoadTexture
            // 
            this.btnLoadTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTexture.Location = new System.Drawing.Point(1425, 94);
            this.btnLoadTexture.Name = "btnLoadTexture";
            this.btnLoadTexture.Size = new System.Drawing.Size(141, 23);
            this.btnLoadTexture.TabIndex = 9;
            this.btnLoadTexture.Text = "Load Texture";
            this.btnLoadTexture.UseVisualStyleBackColor = true;
            // 
            // lblZRotation
            // 
            this.lblZRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZRotation.Location = new System.Drawing.Point(1425, 585);
            this.lblZRotation.Name = "lblZRotation";
            this.lblZRotation.Size = new System.Drawing.Size(79, 13);
            this.lblZRotation.TabIndex = 18;
            this.lblZRotation.Text = "Z Rotation:";
            this.lblZRotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nUDZRotation
            // 
            this.nUDZRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDZRotation.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDZRotation.Location = new System.Drawing.Point(1510, 583);
            this.nUDZRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nUDZRotation.Name = "nUDZRotation";
            this.nUDZRotation.Size = new System.Drawing.Size(56, 20);
            this.nUDZRotation.TabIndex = 17;
            // 
            // lblXRotation
            // 
            this.lblXRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXRotation.Location = new System.Drawing.Point(1428, 533);
            this.lblXRotation.Name = "lblXRotation";
            this.lblXRotation.Size = new System.Drawing.Size(76, 13);
            this.lblXRotation.TabIndex = 15;
            this.lblXRotation.Text = "X Rotation:";
            this.lblXRotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYRotation
            // 
            this.lblYRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYRotation.Location = new System.Drawing.Point(1425, 559);
            this.lblYRotation.Name = "lblYRotation";
            this.lblYRotation.Size = new System.Drawing.Size(79, 13);
            this.lblYRotation.TabIndex = 16;
            this.lblYRotation.Text = "Y Rotation:";
            this.lblYRotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nUDXRotation
            // 
            this.nUDXRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDXRotation.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDXRotation.Location = new System.Drawing.Point(1510, 531);
            this.nUDXRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nUDXRotation.Name = "nUDXRotation";
            this.nUDXRotation.Size = new System.Drawing.Size(56, 20);
            this.nUDXRotation.TabIndex = 13;
            // 
            // nUDYRotation
            // 
            this.nUDYRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDYRotation.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDYRotation.Location = new System.Drawing.Point(1510, 557);
            this.nUDYRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nUDYRotation.Name = "nUDYRotation";
            this.nUDYRotation.Size = new System.Drawing.Size(56, 20);
            this.nUDYRotation.TabIndex = 14;
            // 
            // grpTexture
            // 
            this.grpTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTexture.Controls.Add(this.cmbTextureMethod);
            this.grpTexture.Controls.Add(this.lblTextureMethod);
            this.grpTexture.Location = new System.Drawing.Point(1425, 41);
            this.grpTexture.Name = "grpTexture";
            this.grpTexture.Size = new System.Drawing.Size(141, 47);
            this.grpTexture.TabIndex = 19;
            this.grpTexture.TabStop = false;
            this.grpTexture.Text = "Texture";
            // 
            // cmbTextureMethod
            // 
            this.cmbTextureMethod.FormattingEnabled = true;
            this.cmbTextureMethod.Location = new System.Drawing.Point(75, 19);
            this.cmbTextureMethod.Name = "cmbTextureMethod";
            this.cmbTextureMethod.Size = new System.Drawing.Size(60, 21);
            this.cmbTextureMethod.TabIndex = 13;
            // 
            // lblTextureMethod
            // 
            this.lblTextureMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextureMethod.Location = new System.Drawing.Point(9, 22);
            this.lblTextureMethod.Name = "lblTextureMethod";
            this.lblTextureMethod.Size = new System.Drawing.Size(60, 13);
            this.lblTextureMethod.TabIndex = 14;
            this.lblTextureMethod.Text = "Method:";
            this.lblTextureMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmObjViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 811);
            this.Controls.Add(this.grpTexture);
            this.Controls.Add(this.lblZRotation);
            this.Controls.Add(this.nUDZRotation);
            this.Controls.Add(this.lblXRotation);
            this.Controls.Add(this.lblYRotation);
            this.Controls.Add(this.nUDXRotation);
            this.Controls.Add(this.nUDYRotation);
            this.Controls.Add(this.btnLoadTexture);
            this.Controls.Add(this.btnLoadObj);
            this.Controls.Add(this.grpAutoRotate);
            this.Controls.Add(this.btnResetView);
            this.Controls.Add(this.grpMouseOptions);
            this.Controls.Add(this.grpMouseWheelSensitivity);
            this.Controls.Add(this.glControlMain);
            this.MinimumSize = new System.Drawing.Size(892, 511);
            this.Name = "frmObjViewer";
            this.ShowIcon = false;
            this.Text = "Obj Viewer";
            this.grpMouseWheelSensitivity.ResumeLayout(false);
            this.grpMouseWheelSensitivity.PerformLayout();
            this.grpMouseOptions.ResumeLayout(false);
            this.grpMouseOptions.PerformLayout();
            this.grpAutoRotate.ResumeLayout(false);
            this.grpAutoRotate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDZRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDXRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDYRotation)).EndInit();
            this.grpTexture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private OpenTK.GLControl glControlMain;
        private System.Windows.Forms.CheckBox chkInvertMouseWheel;
        private System.Windows.Forms.GroupBox grpMouseWheelSensitivity;
        private System.Windows.Forms.RadioButton rbHighSensitivityWheel;
        private System.Windows.Forms.RadioButton rbMediumSensitivityWheel;
        private System.Windows.Forms.RadioButton rbLowSensitivityWheel;
        private System.Windows.Forms.CheckBox chkInvertMouse;
        private System.Windows.Forms.GroupBox grpMouseOptions;
        private System.Windows.Forms.RadioButton rbHighSensitivity;
        private System.Windows.Forms.RadioButton rbMediumSensitivity;
        private System.Windows.Forms.RadioButton rbLowSensitivity;
        private System.Windows.Forms.Button btnResetView;
        private System.Windows.Forms.GroupBox grpAutoRotate;
        private System.Windows.Forms.RadioButton rbARHighSpeed;
        private System.Windows.Forms.CheckBox chkAutoRotate;
        private System.Windows.Forms.RadioButton rbARLowSpeed;
        private System.Windows.Forms.RadioButton rbARMediumSpeed;
        private System.Windows.Forms.Button btnLoadObj;
        private System.Windows.Forms.Button btnLoadTexture;
        private System.Windows.Forms.Label lblZRotation;
        private System.Windows.Forms.NumericUpDown nUDZRotation;
        private System.Windows.Forms.Label lblXRotation;
        private System.Windows.Forms.Label lblYRotation;
        private System.Windows.Forms.NumericUpDown nUDXRotation;
        private System.Windows.Forms.NumericUpDown nUDYRotation;
        private System.Windows.Forms.GroupBox grpTexture;
        private System.Windows.Forms.ComboBox cmbTextureMethod;
        private System.Windows.Forms.Label lblTextureMethod;
    }
}

