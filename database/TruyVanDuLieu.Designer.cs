namespace database
{
    partial class TruyVanDuLieu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            panelControls = new Panel();
            comboBoxQueryType = new ComboBox();
            textBoxOrderId = new TextBox();
            btnSearch = new Button();
            dataGridViewResults = new DataGridView();
            tableLayoutPanel.SuspendLayout();
            panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewResults)).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(250, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(400, 30);
            lblTitle.Text = "Hệ Thống Truy Vấn Dữ Liệu Bán Sách";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel.Controls.Add(panelControls, 0, 0);
            tableLayoutPanel.Controls.Add(dataGridViewResults, 1, 0);
            tableLayoutPanel.Location = new System.Drawing.Point(12, 80);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Size = new System.Drawing.Size(960, 550);
            tableLayoutPanel.TabIndex = 1;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(comboBoxQueryType);
            panelControls.Controls.Add(textBoxOrderId);
            panelControls.Controls.Add(btnSearch);
            panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControls.Name = "panelControls";
            // 
            // comboBoxQueryType
            // 
            comboBoxQueryType.FormattingEnabled = true;
            comboBoxQueryType.Location = new System.Drawing.Point(10, 10);
            comboBoxQueryType.Name = "comboBoxQueryType";
            comboBoxQueryType.Size = new System.Drawing.Size(170, 28);
            comboBoxQueryType.TabIndex = 0;
            comboBoxQueryType.SelectedIndexChanged += comboBoxQueryType_SelectedIndexChanged;
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.Location = new System.Drawing.Point(10, 50);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.Size = new System.Drawing.Size(170, 27);
            textBoxOrderId.TabIndex = 1;
            textBoxOrderId.PlaceholderText = "Nhập Mã Đơn Hàng";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(10, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(170, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewResults.Location = new System.Drawing.Point(195, 3);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new System.Drawing.Size(762, 544);
            dataGridViewResults.TabIndex = 0;
            // 
            // TruyVanDuLieu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 661);
            Controls.Add(tableLayoutPanel);
            Controls.Add(lblTitle);
            Name = "TruyVanDuLieu";
            Text = "Truy Vấn Quản Lý Bán Sách";
            Load += TruyVanDuLieu_Load;
            ResumeLayout(false);
            PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewResults)).EndInit();
        }

        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panelControls;
        private ComboBox comboBoxQueryType;
        private TextBox textBoxOrderId;
        private Button btnSearch;
        private DataGridView dataGridViewResults;
    }
}