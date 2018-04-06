using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glee = Microsoft.Glee.Drawing;
using GleeUI = Microsoft.Glee.GraphViewerGdi;
using EDA = ProjetoGrafos.DataStructure;
using ProjetoGrafos.DataStructure;

namespace ProjetoGrafos
{
    /// <summary>
    /// Classe que representa o form principal da aplicação.
    /// </summary>
    public partial class Principal : Form
    {

        #region Atributos

        /// <summary>
        /// Instância do grafo a ser utilizada no formulário.
        /// </summary>
        private EDA.Graph graph;

        #endregion

        #region Construtores

        /// <summary>
        /// Cria nova instância do form principal.
        /// </summary>
        public Principal()
        {
            InitializeComponent();
            this.graph = new EDA.Graph();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Atribui aos controles o conteúdo do grafo.
        /// </summary>
        private void SetGraphControls(bool drawGraph = true)
        {
            List<EDA.Edge> edges = new List<EDA.Edge>();
            EDA.Node[] nodes = this.graph.Nodes;
            // Limpa controles..
            txtNodeName.Clear();
            cmbNodeFrom.Items.Clear();
            cmbNodeTo.Items.Clear();            
            lstArcs.Items.Clear();
            // Carrega nós e agrupa arcos..
            foreach (EDA.Node node in nodes)
            {
                edges.AddRange(node.Edges);
                // Adiciona nós ao combo..
                cmbNodeFrom.Items.Add(node);
                cmbNodeTo.Items.Add(node);                
            }
            // Adiciona os arcos ao listbox..
            foreach (EDA.Edge edge in edges)
            {
                lstArcs.Items.Add(edge);
            }
            if (drawGraph)
            {
                DrawGraph(null);
            }
        }

        /// <summary>
        /// Desenha o grafo atual.
        /// </summary>
        private void DrawGraph(EDA.Node[] highlightedNodes)
        {
            List<EDA.Edge> edges = new List<EDA.Edge>();
            Glee.Graph drawingGraph = new Glee.Graph("Grafo - EDA2");
            // Adiciona nós ao grafo..
            foreach (EDA.Node node in this.graph.Nodes)
            {
                Glee.Node drawingNode = drawingGraph.AddNode(node.Name);
                drawingNode.Attr.Shape = Glee.Shape.Circle;
                if (highlightedNodes != null && Array.IndexOf(highlightedNodes, node) >= 0)
                {
                    drawingNode.Attr.Color = Glee.Color.Red;
                }
                // Consolida os arcos..
                edges.AddRange(node.Edges);
            }
            foreach (EDA.Edge edge in edges)
            {
                Glee.Edge drawingEdge = drawingGraph.AddEdge(edge.From.Name, edge.To.Name);
                drawingEdge.Attr.Label = String.Format("{0:F4}", edge.Cost);
            }
            // Gera controle de desenho..
            GleeUI.GViewer viewer = new GleeUI.GViewer();
            viewer.NavigationVisible = false;
            viewer.OutsideAreaBrush = Brushes.White;
            viewer.RemoveToolbar();
            viewer.Graph = drawingGraph;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGraph.Controls.Clear();
            pnlGraph.Controls.Add(viewer);
        }
            
        #endregion

        #region Eventos

        /// <summary>
        /// Clique do botão AddNode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNodeName.Text.Trim()))
            {
                this.graph.AddNode(txtNodeName.Text);
            }
            SetGraphControls();
        }

        /// <summary>
        /// Clique do botão remover nó.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNodeName.Text.Trim()))
            {
                this.graph.RemoveNode(txtNodeName.Text);
            }
            SetGraphControls();
        }

        /// <summary>
        /// Clique do botão adicionar arco.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddArc_Click(object sender, EventArgs e)
        {
            if (cmbNodeTo.SelectedItem != null && cmbNodeFrom.SelectedItem != null && !String.IsNullOrEmpty(txtCost.Text.Trim()))
            {
                string nodeTo = (cmbNodeTo.SelectedItem as EDA.Node).Name;
                string nodeFrom = (cmbNodeFrom.SelectedItem as EDA.Node).Name;
                double cost = Double.Parse(txtCost.Text);
                // Adiciona arco..
                this.graph.AddEdge(nodeFrom, nodeTo, cost);
            }
            SetGraphControls();
        }

        /// <summary>
        /// Clique do botão que limpa arcos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveArcs_Click(object sender, EventArgs e)
        {
            // Adiciona nós ao grafo..
            foreach (EDA.Node node in this.graph.Nodes)
            {
                node.Edges.Clear();
            }
            SetGraphControls();
        }

        /// <summary>
        /// Clique do botão de exibir cobertura minima de vertices.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAchaCoberturaMinimaVertices_Click(object sender, EventArgs e)
        {            
            EDA.Node[] nos_cobertura_minima = this.graph.AchaCoberturaMinimaVertices();
            SetGraphControls(false);
            DrawGraph(nos_cobertura_minima);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            g.AddNode("A");
            g.AddNode("B");
            g.AddNode("C");
            g.AddNode("D");
            g.AddNode("E");
            g.AddNode("F");
            
            g.AddEdge("A", "B", 1);
            g.AddEdge("B", "A", 1);
            g.AddEdge("A", "C", 1);
            g.AddEdge("C", "A", 1);
            g.AddEdge("A", "F", 1);
            g.AddEdge("F", "A", 1);
            g.AddEdge("B", "C", 1);
            g.AddEdge("C", "B", 1);
            g.AddEdge("C", "D", 1);
            g.AddEdge("D", "C", 1);
            g.AddEdge("C", "F", 1);
            g.AddEdge("F", "C", 1);
            g.AddEdge("D", "F", 1);
            g.AddEdge("F", "D", 1);
            g.AddEdge("D", "E", 1);
            g.AddEdge("E", "D", 1);
            g.AddEdge("E", "F", 1);
            g.AddEdge("F", "E", 1);            
            this.graph = g;
            SetGraphControls();           

        }      
    }
}
