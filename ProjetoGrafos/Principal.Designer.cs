namespace ProjetoGrafos
{
    partial class Principal
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
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.gbGraph = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemoveArcs = new System.Windows.Forms.Button();
            this.lstArcs = new System.Windows.Forms.ListBox();
            this.btnAddArc = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblEdge = new System.Windows.Forms.Label();
            this.cmbNodeFrom = new System.Windows.Forms.ComboBox();
            this.cmbNodeTo = new System.Windows.Forms.ComboBox();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.lblNodeName = new System.Windows.Forms.Label();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnAchaCoberturaMinimaVertices = new System.Windows.Forms.Button();
            this.gbGraph.SuspendLayout();
            this.gbOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGraph
            // 
            this.pnlGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraph.Location = new System.Drawing.Point(322, 12);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(450, 373);
            this.pnlGraph.TabIndex = 0;
            // 
            // gbGraph
            // 
            this.gbGraph.Controls.Add(this.button1);
            this.gbGraph.Controls.Add(this.btnRemoveArcs);
            this.gbGraph.Controls.Add(this.lstArcs);
            this.gbGraph.Controls.Add(this.btnAddArc);
            this.gbGraph.Controls.Add(this.txtCost);
            this.gbGraph.Controls.Add(this.lblEdge);
            this.gbGraph.Controls.Add(this.cmbNodeFrom);
            this.gbGraph.Controls.Add(this.cmbNodeTo);
            this.gbGraph.Controls.Add(this.btnRemoveNode);
            this.gbGraph.Controls.Add(this.btnAddNode);
            this.gbGraph.Controls.Add(this.txtNodeName);
            this.gbGraph.Controls.Add(this.lblNodeName);
            this.gbGraph.Location = new System.Drawing.Point(12, 6);
            this.gbGraph.Name = "gbGraph";
            this.gbGraph.Size = new System.Drawing.Size(304, 273);
            this.gbGraph.TabIndex = 1;
            this.gbGraph.TabStop = false;
            this.gbGraph.Text = "Grafo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gera Grafo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveArcs
            // 
            this.btnRemoveArcs.Location = new System.Drawing.Point(187, 17);
            this.btnRemoveArcs.Name = "btnRemoveArcs";
            this.btnRemoveArcs.Size = new System.Drawing.Size(96, 23);
            this.btnRemoveArcs.TabIndex = 10;
            this.btnRemoveArcs.Text = "Limpar Arcos";
            this.btnRemoveArcs.UseVisualStyleBackColor = true;
            this.btnRemoveArcs.Click += new System.EventHandler(this.btnRemoveArcs_Click);
            // 
            // lstArcs
            // 
            this.lstArcs.FormattingEnabled = true;
            this.lstArcs.Location = new System.Drawing.Point(47, 82);
            this.lstArcs.Name = "lstArcs";
            this.lstArcs.Size = new System.Drawing.Size(251, 147);
            this.lstArcs.TabIndex = 9;
            // 
            // btnAddArc
            // 
            this.btnAddArc.Location = new System.Drawing.Point(266, 55);
            this.btnAddArc.Name = "btnAddArc";
            this.btnAddArc.Size = new System.Drawing.Size(32, 23);
            this.btnAddArc.TabIndex = 8;
            this.btnAddArc.Text = "+";
            this.btnAddArc.UseVisualStyleBackColor = true;
            this.btnAddArc.Click += new System.EventHandler(this.btnAddArc_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(202, 56);
            this.txtCost.MaxLength = 5;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(58, 20);
            this.txtCost.TabIndex = 7;
            // 
            // lblEdge
            // 
            this.lblEdge.AutoSize = true;
            this.lblEdge.Location = new System.Drawing.Point(4, 58);
            this.lblEdge.Name = "lblEdge";
            this.lblEdge.Size = new System.Drawing.Size(40, 13);
            this.lblEdge.TabIndex = 6;
            this.lblEdge.Text = "Aresta:";
            // 
            // cmbNodeFrom
            // 
            this.cmbNodeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodeFrom.FormattingEnabled = true;
            this.cmbNodeFrom.Location = new System.Drawing.Point(47, 55);
            this.cmbNodeFrom.Name = "cmbNodeFrom";
            this.cmbNodeFrom.Size = new System.Drawing.Size(69, 21);
            this.cmbNodeFrom.TabIndex = 5;
            // 
            // cmbNodeTo
            // 
            this.cmbNodeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodeTo.FormattingEnabled = true;
            this.cmbNodeTo.Location = new System.Drawing.Point(127, 55);
            this.cmbNodeTo.Name = "cmbNodeTo";
            this.cmbNodeTo.Size = new System.Drawing.Size(69, 21);
            this.cmbNodeTo.TabIndex = 4;
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Location = new System.Drawing.Point(149, 22);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(32, 23);
            this.btnRemoveNode.TabIndex = 3;
            this.btnRemoveNode.Text = "-";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(111, 22);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(32, 23);
            this.btnAddNode.TabIndex = 2;
            this.btnAddNode.Text = "+";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(47, 24);
            this.txtNodeName.MaxLength = 5;
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(58, 20);
            this.txtNodeName.TabIndex = 1;
            // 
            // lblNodeName
            // 
            this.lblNodeName.AutoSize = true;
            this.lblNodeName.Location = new System.Drawing.Point(17, 27);
            this.lblNodeName.Name = "lblNodeName";
            this.lblNodeName.Size = new System.Drawing.Size(24, 13);
            this.lblNodeName.TabIndex = 0;
            this.lblNodeName.Text = "Nó:";
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.btnAchaCoberturaMinimaVertices);
            this.gbOperations.Location = new System.Drawing.Point(12, 285);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(304, 100);
            this.gbOperations.TabIndex = 2;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operações";
            // 
            // btnAchaCoberturaMinimaVertices
            // 
            this.btnAchaCoberturaMinimaVertices.Location = new System.Drawing.Point(7, 30);
            this.btnAchaCoberturaMinimaVertices.Name = "btnAchaCoberturaMinimaVertices";
            this.btnAchaCoberturaMinimaVertices.Size = new System.Drawing.Size(292, 44);
            this.btnAchaCoberturaMinimaVertices.TabIndex = 12;
            this.btnAchaCoberturaMinimaVertices.Text = "Mostrar Cobertura de Vertices Minima";
            this.btnAchaCoberturaMinimaVertices.UseVisualStyleBackColor = true;
            this.btnAchaCoberturaMinimaVertices.Click += new System.EventHandler(this.btnAchaCoberturaMinimaVertices_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 400);
            this.Controls.Add(this.gbOperations);
            this.Controls.Add(this.gbGraph);
            this.Controls.Add(this.pnlGraph);
            this.Name = "Principal";
            this.Text = "Grafos";
            this.gbGraph.ResumeLayout(false);
            this.gbGraph.PerformLayout();
            this.gbOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.GroupBox gbGraph;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Label lblNodeName;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.Button btnAddArc;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblEdge;
        private System.Windows.Forms.ComboBox cmbNodeFrom;
        private System.Windows.Forms.ComboBox cmbNodeTo;
        private System.Windows.Forms.Button btnRemoveArcs;
        private System.Windows.Forms.ListBox lstArcs;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnAchaCoberturaMinimaVertices;
        private System.Windows.Forms.Button button1;
    }
}

