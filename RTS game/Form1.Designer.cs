namespace RTS_game
{
    partial class Form1
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
            this.lblROUND = new System.Windows.Forms.Label();
            this.btnSTART = new System.Windows.Forms.Button();
            this.btnPAUSE = new System.Windows.Forms.Button();
            this.Mapgrp = new System.Windows.Forms.GroupBox();
            this.infotxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SAVEGAME = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.DisplayResouce = new System.Windows.Forms.Button();
            this.roundCounter = new System.Windows.Forms.Label();
            this.BTNREAD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblROUND
            // 
            this.lblROUND.AutoSize = true;
            this.lblROUND.Location = new System.Drawing.Point(750, 434);
            this.lblROUND.Name = "lblROUND";
            this.lblROUND.Size = new System.Drawing.Size(94, 17);
            this.lblROUND.TabIndex = 1;
            this.lblROUND.Text = "current round";
            this.lblROUND.Click += new System.EventHandler(this.lblROUND_Click);
            // 
            // btnSTART
            // 
            this.btnSTART.Location = new System.Drawing.Point(648, 434);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(75, 23);
            this.btnSTART.TabIndex = 2;
            this.btnSTART.Text = "start";
            this.btnSTART.UseVisualStyleBackColor = true;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // btnPAUSE
            // 
            this.btnPAUSE.Location = new System.Drawing.Point(864, 431);
            this.btnPAUSE.Name = "btnPAUSE";
            this.btnPAUSE.Size = new System.Drawing.Size(75, 23);
            this.btnPAUSE.TabIndex = 3;
            this.btnPAUSE.Text = "pause";
            this.btnPAUSE.UseVisualStyleBackColor = true;
            this.btnPAUSE.Click += new System.EventHandler(this.btnPAUSE_Click);
            // 
            // Mapgrp
            // 
            this.Mapgrp.Location = new System.Drawing.Point(43, 12);
            this.Mapgrp.Name = "Mapgrp";
            this.Mapgrp.Size = new System.Drawing.Size(526, 408);
            this.Mapgrp.TabIndex = 6;
            this.Mapgrp.TabStop = false;
            this.Mapgrp.Text = "groupBox1";
            this.Mapgrp.Enter += new System.EventHandler(this.Mapgrp_Enter);
            // 
            // infotxt
            // 
            this.infotxt.Location = new System.Drawing.Point(762, 78);
            this.infotxt.Name = "infotxt";
            this.infotxt.Size = new System.Drawing.Size(158, 22);
            this.infotxt.TabIndex = 7;
            this.infotxt.TextChanged += new System.EventHandler(this.infotxt_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SAVEGAME
            // 
            this.SAVEGAME.Location = new System.Drawing.Point(753, 385);
            this.SAVEGAME.Name = "SAVEGAME";
            this.SAVEGAME.Size = new System.Drawing.Size(75, 35);
            this.SAVEGAME.TabIndex = 8;
            this.SAVEGAME.Text = "save";
            this.SAVEGAME.UseVisualStyleBackColor = true;
            this.SAVEGAME.Click += new System.EventHandler(this.SAVEGAME_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(750, 259);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(115, 17);
            this.lblRes.TabIndex = 10;
            this.lblRes.Text = "displayresources";
            this.lblRes.Click += new System.EventHandler(this.resourcegrp_Click);
            // 
            // DisplayResouce
            // 
            this.DisplayResouce.Location = new System.Drawing.Point(711, 305);
            this.DisplayResouce.Name = "DisplayResouce";
            this.DisplayResouce.Size = new System.Drawing.Size(209, 23);
            this.DisplayResouce.TabIndex = 11;
            this.DisplayResouce.Text = "display resources";
            this.DisplayResouce.UseVisualStyleBackColor = true;
            this.DisplayResouce.Click += new System.EventHandler(this.resourcebtn_Click);
            // 
            // roundCounter
            // 
            this.roundCounter.AutoSize = true;
            this.roundCounter.Location = new System.Drawing.Point(763, 215);
            this.roundCounter.Name = "roundCounter";
            this.roundCounter.Size = new System.Drawing.Size(94, 17);
            this.roundCounter.TabIndex = 12;
            this.roundCounter.Text = "current round";
            // 
            // BTNREAD
            // 
            this.BTNREAD.Location = new System.Drawing.Point(753, 356);
            this.BTNREAD.Name = "BTNREAD";
            this.BTNREAD.Size = new System.Drawing.Size(75, 23);
            this.BTNREAD.TabIndex = 13;
            this.BTNREAD.Text = "READ";
            this.BTNREAD.UseVisualStyleBackColor = true;
            this.BTNREAD.Click += new System.EventHandler(this.BTNREAD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 466);
            this.Controls.Add(this.BTNREAD);
            this.Controls.Add(this.roundCounter);
            this.Controls.Add(this.DisplayResouce);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.SAVEGAME);
            this.Controls.Add(this.infotxt);
            this.Controls.Add(this.Mapgrp);
            this.Controls.Add(this.btnPAUSE);
            this.Controls.Add(this.btnSTART);
            this.Controls.Add(this.lblROUND);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblROUND;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.Button btnPAUSE;
        private System.Windows.Forms.GroupBox Mapgrp;
        private System.Windows.Forms.TextBox infotxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SAVEGAME;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button DisplayResouce;
        private System.Windows.Forms.Label roundCounter;
        private System.Windows.Forms.Button BTNREAD;
    }
}

