namespace SvgDemoWinForms
{
        public partial class MainForm : Form
        {
            private StatusStrip statusStrip1;
            private ToolStripStatusLabel statusLabel;

            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            // This utility method assigns the value of a ToolStripItem
            // control's Text property to the Text property of the
            // ToolStripStatusLabel.
            private void UpdateStatus(ToolStripItem item)
            {
                if (item != null)
                {
                    string msg = String.Format("{0} selected", item.Text);
                    this.statusStrip1.Items[0].Text = msg;
                }
            }

            // This method is the DropDownItemClicked event handler.
            // It passes the ClickedItem object to a utility method
            // called UpdateStatus, which updates the text displayed
            // in the StatusStrip control.
            private void fileToolStripMenuItem_DropDownItemClicked(
                object sender, ToolStripItemClickedEventArgs e)
            {
                this.UpdateStatus(e.ClickedItem);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            exportSVGToolStripMenuItem = new ToolStripMenuItem();
            exportPNGToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            modeToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            ellipseToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            lineToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            showInBrowserToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            jsonFormToolStripMenuItem = new ToolStripMenuItem();
            svgFormToolStripMenuItem = new ToolStripMenuItem();
            treeFormToolStripMenuItem = new ToolStripMenuItem();
            logFormToolStripMenuItem = new ToolStripMenuItem();
            customToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelMouse = new ToolStripStatusLabel();
            statusLabel = new ToolStripStatusLabel();
            modifiedStatusLabel = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, modeToolStripMenuItem, toolsToolStripMenuItem, windowsToolStripMenuItem, customToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(559, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator7, exportSVGToolStripMenuItem, exportPNGToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            fileToolStripMenuItem.ToolTipText = "File menu items";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.ToolTipText = "Create new file";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.ToolTipText = "Open file";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.ToolTipText = "Save file";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            saveAsToolStripMenuItem.ToolTipText = "Save file with new name";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(143, 6);
            // 
            // exportSVGToolStripMenuItem
            // 
            exportSVGToolStripMenuItem.Name = "exportSVGToolStripMenuItem";
            exportSVGToolStripMenuItem.Size = new Size(146, 22);
            exportSVGToolStripMenuItem.Text = "Export SV&G ...";
            exportSVGToolStripMenuItem.Click += exportSVGToolStripMenuItem_Click;
            // 
            // exportPNGToolStripMenuItem
            // 
            exportPNGToolStripMenuItem.Name = "exportPNGToolStripMenuItem";
            exportPNGToolStripMenuItem.Size = new Size(146, 22);
            exportPNGToolStripMenuItem.Text = "Expor&t PNG ...";
            exportPNGToolStripMenuItem.Click += exportPNGToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            exitToolStripMenuItem.Size = new Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.ToolTipText = "Exit application";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, deleteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(164, 22);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.ToolTipText = "Undo last item";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(164, 22);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.ToolTipText = "Redoes last undone change";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(161, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(164, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.ToolTipText = "Deletes current selection";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(164, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            selectAllToolStripMenuItem.ToolTipText = "Selects all items";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            clearToolStripMenuItem.Size = new Size(164, 22);
            clearToolStripMenuItem.Text = "C&lear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // modeToolStripMenuItem
            // 
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem, toolStripMenuItem1, ellipseToolStripMenuItem, rectangleToolStripMenuItem, lineToolStripMenuItem, circleToolStripMenuItem, squareToolStripMenuItem });
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(50, 20);
            modeToolStripMenuItem.Text = "&Mode";
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            selectToolStripMenuItem.Size = new Size(199, 22);
            selectToolStripMenuItem.Text = "&Select ";
            selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(196, 6);
            // 
            // ellipseToolStripMenuItem
            // 
            ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            ellipseToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
            ellipseToolStripMenuItem.Size = new Size(199, 22);
            ellipseToolStripMenuItem.Text = "&Ellipse";
            ellipseToolStripMenuItem.Click += ellipseToolStripMenuItem_Click_1;
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
            rectangleToolStripMenuItem.Size = new Size(199, 22);
            rectangleToolStripMenuItem.Text = "&Rectangle";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click_1;
            // 
            // lineToolStripMenuItem
            // 
            lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            lineToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.L;
            lineToolStripMenuItem.Size = new Size(199, 22);
            lineToolStripMenuItem.Text = "&Line";
            lineToolStripMenuItem.Click += lineToolStripMenuItem_Click;
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            circleToolStripMenuItem.Size = new Size(199, 22);
            circleToolStripMenuItem.Text = "&Circle";
            circleToolStripMenuItem.Click += circleToolStripMenuItem_Click;
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Q;
            squareToolStripMenuItem.Size = new Size(199, 22);
            squareToolStripMenuItem.Text = "S&quare";
            squareToolStripMenuItem.Click += squareToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showInBrowserToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // showInBrowserToolStripMenuItem
            // 
            showInBrowserToolStripMenuItem.Name = "showInBrowserToolStripMenuItem";
            showInBrowserToolStripMenuItem.Size = new Size(161, 22);
            showInBrowserToolStripMenuItem.Text = "&Show in Browser";
            showInBrowserToolStripMenuItem.Click += showInBrowserToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jsonFormToolStripMenuItem, svgFormToolStripMenuItem, treeFormToolStripMenuItem, logFormToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(68, 20);
            windowsToolStripMenuItem.Text = "&Windows";
            // 
            // jsonFormToolStripMenuItem
            // 
            jsonFormToolStripMenuItem.Name = "jsonFormToolStripMenuItem";
            jsonFormToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.J;
            jsonFormToolStripMenuItem.Size = new Size(192, 22);
            jsonFormToolStripMenuItem.Text = "&Json Form ";
            jsonFormToolStripMenuItem.Click += jsonFormToolStripMenuItem_Click;
            // 
            // svgFormToolStripMenuItem
            // 
            svgFormToolStripMenuItem.Name = "svgFormToolStripMenuItem";
            svgFormToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            svgFormToolStripMenuItem.Size = new Size(192, 22);
            svgFormToolStripMenuItem.Text = "&SVG Form";
            svgFormToolStripMenuItem.Click += svgFormToolStripMenuItem_Click;
            // 
            // treeFormToolStripMenuItem
            // 
            treeFormToolStripMenuItem.Name = "treeFormToolStripMenuItem";
            treeFormToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.T;
            treeFormToolStripMenuItem.Size = new Size(192, 22);
            treeFormToolStripMenuItem.Text = "&Tree Form";
            treeFormToolStripMenuItem.Click += treeFormToolStripMenuItem_Click;
            // 
            // logFormToolStripMenuItem
            // 
            logFormToolStripMenuItem.Name = "logFormToolStripMenuItem";
            logFormToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.L;
            logFormToolStripMenuItem.Size = new Size(192, 22);
            logFormToolStripMenuItem.Text = "&Log Form";
            logFormToolStripMenuItem.Click += logFormToolStripMenuItem_Click;
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new Size(61, 20);
            customToolStripMenuItem.Text = "&Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelMouse, statusLabel, modifiedStatusLabel });
            statusStrip1.Location = new Point(0, 314);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 16, 0);
            statusStrip1.Size = new Size(559, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelMouse
            // 
            statusLabelMouse.AutoSize = false;
            statusLabelMouse.Name = "statusLabelMouse";
            statusLabelMouse.Size = new Size(150, 27);
            statusLabelMouse.Text = "X, Y";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 27);
            statusLabel.Text = "Status";
            // 
            // modifiedStatusLabel
            // 
            modifiedStatusLabel.Name = "modifiedStatusLabel";
            modifiedStatusLabel.Size = new Size(70, 27);
            modifiedStatusLabel.Text = "Unmodified";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 290);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 346);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
            private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
            private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
            private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
            private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem showInBrowserToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem jsonFormToolStripMenuItem;
        private ToolStripMenuItem svgFormToolStripMenuItem;
        private ToolStripMenuItem treeFormToolStripMenuItem;
        private ToolStripStatusLabel statusLabelMouse;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem ellipseToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem lineToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem logFormToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem exportPNGToolStripMenuItem;
        private ToolStripMenuItem exportSVGToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripStatusLabel modifiedStatusLabel;
        private ToolStripMenuItem customToolStripMenuItem;
    }
    
}