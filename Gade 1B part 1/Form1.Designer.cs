﻿namespace Gade_1B_part_1
{
    partial class frmGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redPlayArea = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.bntUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.EnemyList = new System.Windows.Forms.ListBox();
            this.AttackBtn = new System.Windows.Forms.Button();
            this.ListOfEnemies = new System.Windows.Forms.ListBox();
            this.Attack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redPlayArea
            // 
            this.redPlayArea.Location = new System.Drawing.Point(30, 28);
            this.redPlayArea.Margin = new System.Windows.Forms.Padding(2);
            this.redPlayArea.Name = "redPlayArea";
            this.redPlayArea.Size = new System.Drawing.Size(601, 601);
            this.redPlayArea.TabIndex = 0;
            this.redPlayArea.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(734, 28);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bntUp
            // 
            this.bntUp.Location = new System.Drawing.Point(734, 151);
            this.bntUp.Margin = new System.Windows.Forms.Padding(2);
            this.bntUp.Name = "bntUp";
            this.bntUp.Size = new System.Drawing.Size(90, 27);
            this.bntUp.TabIndex = 2;
            this.bntUp.Text = "Up";
            this.bntUp.UseVisualStyleBackColor = true;
            this.bntUp.Click += new System.EventHandler(this.bntUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(734, 212);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(90, 27);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(660, 185);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(90, 27);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(808, 185);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(90, 27);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // EnemyList
            // 
            this.EnemyList.FormattingEnabled = true;
            this.EnemyList.ItemHeight = 20;
            this.EnemyList.Location = new System.Drawing.Point(723, 349);
            this.EnemyList.Name = "EnemyList";
            this.EnemyList.Size = new System.Drawing.Size(285, 164);
            this.EnemyList.TabIndex = 6;
           // this.EnemyList.SelectedIndexChanged += new System.EventHandler(this.EnemyList_SelectedIndexChanged);
            // 
            // AttackBtn
            // 
            this.AttackBtn.Location = new System.Drawing.Point(1035, 404);
            this.AttackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AttackBtn.Name = "AttackBtn";
            this.AttackBtn.Size = new System.Drawing.Size(187, 71);
            this.AttackBtn.TabIndex = 7;
            this.AttackBtn.Text = "Attack";
            this.AttackBtn.UseVisualStyleBackColor = true;
            this.AttackBtn.Click += new System.EventHandler(this.AttackBtn_Click);
            // 
            // ListOfEnemies
            // 
            this.ListOfEnemies.FormattingEnabled = true;
            this.ListOfEnemies.ItemHeight = 20;
            this.ListOfEnemies.Location = new System.Drawing.Point(636, 300);
            this.ListOfEnemies.Name = "ListOfEnemies";
            this.ListOfEnemies.Size = new System.Drawing.Size(224, 204);
            this.ListOfEnemies.TabIndex = 6;
            this.ListOfEnemies.SelectedIndexChanged += new System.EventHandler(this.ListOfEnemies_SelectedIndexChanged);
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(876, 327);
            this.Attack.Margin = new System.Windows.Forms.Padding(2);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(123, 138);
            this.Attack.TabIndex = 7;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 540);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.ListOfEnemies);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.bntUp);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.redPlayArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGame";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox redPlayArea;
        private Button btnStart;
        private Button bntUp;
        private Button btnDown;
        private Button btnLeft;
        private Button btnRight;
        private ListBox EnemyList;
        private Button AttackBtn;
        private ListBox ListOfEnemies;
        private Button Attack;
    }
}