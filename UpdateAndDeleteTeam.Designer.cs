
namespace Football_Managment
{
    partial class UpdateAndDeleteTeam
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
            this.label6 = new System.Windows.Forms.Label();
            this.label_TeamPlayers = new System.Windows.Forms.Label();
            this.dataGridView_PlayersOfTeam = new System.Windows.Forms.DataGridView();
            this.textBox_TeamNumOfPlayers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxTeamLeagueUD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTeamNationUD = new System.Windows.Forms.TextBox();
            this.textBoxTeamNameUD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_updateTeamImage = new System.Windows.Forms.Button();
            this.pictureBoxTeamUD = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PlayersOfTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Team Logo :";
            // 
            // label_TeamPlayers
            // 
            this.label_TeamPlayers.AutoSize = true;
            this.label_TeamPlayers.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TeamPlayers.Location = new System.Drawing.Point(47, 193);
            this.label_TeamPlayers.Name = "label_TeamPlayers";
            this.label_TeamPlayers.Size = new System.Drawing.Size(89, 17);
            this.label_TeamPlayers.TabIndex = 41;
            this.label_TeamPlayers.Text = "Team Players :";
            // 
            // dataGridView_PlayersOfTeam
            // 
            this.dataGridView_PlayersOfTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_PlayersOfTeam.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_PlayersOfTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PlayersOfTeam.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView_PlayersOfTeam.Location = new System.Drawing.Point(24, 227);
            this.dataGridView_PlayersOfTeam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_PlayersOfTeam.MultiSelect = false;
            this.dataGridView_PlayersOfTeam.Name = "dataGridView_PlayersOfTeam";
            this.dataGridView_PlayersOfTeam.ReadOnly = true;
            this.dataGridView_PlayersOfTeam.RowHeadersWidth = 51;
            this.dataGridView_PlayersOfTeam.RowTemplate.Height = 24;
            this.dataGridView_PlayersOfTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PlayersOfTeam.Size = new System.Drawing.Size(619, 126);
            this.dataGridView_PlayersOfTeam.TabIndex = 40;
            // 
            // textBox_TeamNumOfPlayers
            // 
            this.textBox_TeamNumOfPlayers.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TeamNumOfPlayers.Location = new System.Drawing.Point(285, 155);
            this.textBox_TeamNumOfPlayers.Name = "textBox_TeamNumOfPlayers";
            this.textBox_TeamNumOfPlayers.ReadOnly = true;
            this.textBox_TeamNumOfPlayers.Size = new System.Drawing.Size(118, 24);
            this.textBox_TeamNumOfPlayers.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Team Number of Players :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::Football_Managment.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(473, 638);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 66);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxTeamLeagueUD
            // 
            this.textBoxTeamLeagueUD.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamLeagueUD.Location = new System.Drawing.Point(285, 111);
            this.textBoxTeamLeagueUD.Name = "textBoxTeamLeagueUD";
            this.textBoxTeamLeagueUD.Size = new System.Drawing.Size(346, 24);
            this.textBoxTeamLeagueUD.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Team League :";
            // 
            // textBoxTeamNationUD
            // 
            this.textBoxTeamNationUD.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamNationUD.Location = new System.Drawing.Point(285, 67);
            this.textBoxTeamNationUD.Name = "textBoxTeamNationUD";
            this.textBoxTeamNationUD.Size = new System.Drawing.Size(346, 24);
            this.textBoxTeamNationUD.TabIndex = 31;
            // 
            // textBoxTeamNameUD
            // 
            this.textBoxTeamNameUD.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamNameUD.Location = new System.Drawing.Point(285, 26);
            this.textBoxTeamNameUD.Name = "textBoxTeamNameUD";
            this.textBoxTeamNameUD.Size = new System.Drawing.Size(346, 24);
            this.textBoxTeamNameUD.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Team Nation : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Team Name :";
            // 
            // btn_updateTeamImage
            // 
            this.btn_updateTeamImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateTeamImage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateTeamImage.Image = global::Football_Managment.Properties.Resources.updateimage;
            this.btn_updateTeamImage.Location = new System.Drawing.Point(232, 637);
            this.btn_updateTeamImage.Name = "btn_updateTeamImage";
            this.btn_updateTeamImage.Size = new System.Drawing.Size(184, 66);
            this.btn_updateTeamImage.TabIndex = 37;
            this.btn_updateTeamImage.Text = "Update Image";
            this.btn_updateTeamImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_updateTeamImage.UseVisualStyleBackColor = true;
            this.btn_updateTeamImage.Click += new System.EventHandler(this.btn_updateTeamImage_Click);
            // 
            // pictureBoxTeamUD
            // 
            this.pictureBoxTeamUD.Location = new System.Drawing.Point(174, 377);
            this.pictureBoxTeamUD.Name = "pictureBoxTeamUD";
            this.pictureBoxTeamUD.Size = new System.Drawing.Size(327, 233);
            this.pictureBoxTeamUD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeamUD.TabIndex = 36;
            this.pictureBoxTeamUD.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::Football_Managment.Properties.Resources.update;
            this.btnUpdate.Location = new System.Drawing.Point(10, 638);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 65);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = " Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateAndDeleteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 726);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_TeamPlayers);
            this.Controls.Add(this.dataGridView_PlayersOfTeam);
            this.Controls.Add(this.textBox_TeamNumOfPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_updateTeamImage);
            this.Controls.Add(this.pictureBoxTeamUD);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBoxTeamLeagueUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTeamNationUD);
            this.Controls.Add(this.textBoxTeamNameUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UpdateAndDeleteTeam";
            this.Text = "UpdateAndDeleteTeam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PlayersOfTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_TeamPlayers;
        private System.Windows.Forms.DataGridView dataGridView_PlayersOfTeam;
        public System.Windows.Forms.TextBox textBox_TeamNumOfPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_updateTeamImage;
        public System.Windows.Forms.PictureBox pictureBoxTeamUD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox textBoxTeamLeagueUD;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxTeamNationUD;
        public System.Windows.Forms.TextBox textBoxTeamNameUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}