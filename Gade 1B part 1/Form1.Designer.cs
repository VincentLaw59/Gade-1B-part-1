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
            this.Attack = new System.Windows.Forms.Button();
            this.AttackButton = new System.Windows.Forms.Button();
            this.CmbListOfEnemies = new System.Windows.Forms.ComboBox();
            this.redOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // redPlayArea
            // 
            this.redPlayArea.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redPlayArea.Location = new System.Drawing.Point(46, 44);
            this.redPlayArea.Margin = new System.Windows.Forms.Padding(2);
            this.redPlayArea.Name = "redPlayArea";
            this.redPlayArea.Size = new System.Drawing.Size(750, 750);
            this.redPlayArea.TabIndex = 0;
            this.redPlayArea.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1148, 44);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bntUp
            // 
            this.bntUp.Location = new System.Drawing.Point(1148, 236);
            this.bntUp.Margin = new System.Windows.Forms.Padding(2);
            this.bntUp.Name = "bntUp";
            this.bntUp.Size = new System.Drawing.Size(112, 34);
            this.bntUp.TabIndex = 2;
            this.bntUp.Text = "Up";
            this.bntUp.UseVisualStyleBackColor = true;
            this.bntUp.Click += new System.EventHandler(this.bntUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1148, 331);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(112, 34);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(1031, 289);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(112, 34);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1262, 289);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(112, 34);
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
            // AttackButton
            // 
            this.AttackButton.Location = new System.Drawing.Point(1290, 399);
            this.AttackButton.Margin = new System.Windows.Forms.Padding(2);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(215, 124);
            this.AttackButton.TabIndex = 7;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackBtn_Click);
            // 
            // CmbListOfEnemies
            // 
            this.CmbListOfEnemies.FormattingEnabled = true;
            this.CmbListOfEnemies.Location = new System.Drawing.Point(856, 446);
            this.CmbListOfEnemies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbListOfEnemies.Name = "CmbListOfEnemies";
            this.CmbListOfEnemies.Size = new System.Drawing.Size(404, 33);
            this.CmbListOfEnemies.TabIndex = 8;
            // 
            // redOutput
            // 
            this.redOutput.Location = new System.Drawing.Point(855, 582);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(650, 212);
            this.redOutput.TabIndex = 9;
            this.redOutput.Text = "";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.redOutput);
            this.Controls.Add(this.CmbListOfEnemies);
            this.Controls.Add(this.AttackButton);
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
       // private ListBox ListOfEnemies;
        private Button Attack;
        private Button AttackButton;
        private ComboBox CmbListOfEnemies;
        private RichTextBox redOutput;
    }
}