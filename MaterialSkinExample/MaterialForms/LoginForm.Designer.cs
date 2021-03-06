﻿namespace MaterialSkinExample.MaterialForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uCtrlLoginRegion1 = new MaterialSkinExample.MaterialForms.UCtrlLoginRegion();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uCtrlLoginRegion1);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 369);
            this.panel1.TabIndex = 0;
            // 
            // uCtrlLoginRegion1
            // 
            this.uCtrlLoginRegion1.Depth = 0;
            this.uCtrlLoginRegion1.Location = new System.Drawing.Point(66, 143);
            this.uCtrlLoginRegion1.MouseState = MaterialSkin.MouseState.HOVER;
            this.uCtrlLoginRegion1.Name = "uCtrlLoginRegion1";
            this.uCtrlLoginRegion1.Size = new System.Drawing.Size(378, 190);
            this.uCtrlLoginRegion1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::MaterialSkinExample.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "江苏省财政厅";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialForms.UCtrlLoginRegion uCtrlLoginRegion1;
    }
}