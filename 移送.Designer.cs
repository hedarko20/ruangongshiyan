
namespace LibraryManagement
{
    partial class 移送
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(26, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "移送清单：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(638, 227);
            this.dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(749, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(749, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 35);
            this.button3.TabIndex = 20;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(587, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "一键移送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(749, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 35);
            this.button4.TabIndex = 22;
            this.button4.Text = "退出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "请完善移送清单，主要是分类号，所有的图书的分类号补充完整检查无误后点击“一键移送”完成移送操作。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(37, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "请注意：分类号具体到最多4位，否则保存失败！";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(48, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "分类号参考如下：";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "A1        马克思、恩格斯著作 ",
            "A2        列宁著作 ",
            "A3        斯大林著作",
            "A4        毛泽东著作 ",
            "A49       邓小平著作 ",
            "A5        马克思、恩格斯、列宁、斯大林、毛泽东、邓小平著作汇编",
            "A7        马克思、恩格斯、列宁、斯大林、毛泽东、邓小平生平和传记",
            "A8        马克思主义、列宁主义、毛泽东思想、邓小平理论的学习和研究 ",
            "B82       论理学（道德哲学）",
            "B83       美学 ",
            "B84       心理学 B0 哲学理论",
            "B1         世界哲学",
            "B2         中国哲学 ",
            "B3         亚洲哲学 ",
            "B4         非洲哲学 ",
            "B5         欧洲哲学 ",
            "B6         大洋州哲学 ",
            "B7         美洲哲学 ",
            "B80       思维科学",
            "B81       逻辑学（伦理学）",
            "B9         宗教 ",
            "C0         社会科学理论与方法论 ",
            "C1         社会科学现状及发展 ",
            "C2         社会科学机构、团体、会议 ",
            "C3         社会科学研究方法 ",
            "C4         社会科学教育与普及",
            "C5         社会科学丛书、文集、连续性出版物",
            "C6         社会科学参考工具书 ",
            "C7         社会科学文献检索工具书",
            "C8         统计学 ",
            "C91       社会学",
            "C92       人口学 ",
            "C93       管理学 ",
            "C94       系统科学 ",
            "C95       民族学",
            "C96       人才学 ",
            "C97       劳动科学 ",
            "D0        政治理论",
            "D1        国际共产主义运动 ",
            "D2        中国共产党 ",
            "D33      各国共产党 ",
            "D4        工人、农民、青年、妇女运动与组织 ",
            "D5        世界政治 ",
            "D6        中国政治 ",
            "D73      各国政治 ",
            "D8        外交、国际关系",
            "D9        法律 　",
            "E0        军事理论",
            "E1        世界军事 ",
            "E2        中国军事 ",
            "E3        各国军事 ",
            "E8        战略学、战役学、战术学 ",
            "E9        军事技术 E99 军事地形学、军事地理学 　",
            "F0        经济学 ",
            "F1        世界各国经济概况、经济史、经济地理",
            "F2        经济计划与管理 ",
            "F3        农业经济 ",
            "F4        工业经济 ",
            "F49      信息产业经济（总论） ",
            "F5        交通运输经济",
            "F59      旅游经济 ",
            "F6        邮电经济 ",
            "F7        贸易经济 ",
            "F8        财政、金融 ",
            "G0       文化理论 ",
            "G1       世界各国文化与文化事业 ",
            "G2       信息与知识传播 ",
            "G3       科学、科学研究 ",
            "G4       教育",
            "G40     教育学 ",
            "G41     思想政治教育、德育",
            "G42     教学理论",
            "G43     电化教育",
            "G432   广播、电视教学",
            "G44     教育心理学 ",
            "G45     教师与学生",
            "G46     教育行政 ",
            "G47     学校管理 ",
            "G48     学校建筑和设备管理",
            "G51     世界教育事业 ",
            "G52     中国教育事业",
            "G53     各国教育事业",
            "G61     学前教育、幼儿教育 ",
            "G62     初等教育 ",
            "G63     中等教育 ",
            "G64     高等教育 ",
            "G65     师范教育",
            "G71     职业技术教育 ",
            "G72     成人教育、业余教育 ",
            "G728   广播电视教育/广播电视大学 ",
            "G74     华侨教育、侨民教育",
            "G75     少数民族教育 ",
            "G76     特殊教育 ",
            "G77     社会教育 ",
            "G78     家庭教育 ",
            "G79     自学 ",
            "G8       体育 ",
            "H0       语言学",
            "H1       汉语 ",
            "H2       中国少数民族语言 ",
            "H3       常用外国语 ",
            "H4       汉藏语系 ",
            "H5       世界各地语系 ",
            "H9       国际辅助语 ",
            "I0        文学理论 ",
            "I1        世界文学 ",
            "I2        中国文学",
            "I3/7     各国文学 ",
            "J0       艺术理论",
            "J1       世界各国艺术概况",
            "J2       绘画",
            "J29     书法、篆刻 ",
            "J3       雕塑",
            "J4       摄影艺术 ",
            "J5       工艺美术 ",
            "J59     建筑艺术",
            "J6       音乐",
            "J7       舞蹈 ",
            "J8       戏剧艺术",
            "J9       电影、电视艺术",
            "K0      史学理论",
            "K1      世界史 ",
            "K2      中国史",
            "K3      亚洲史",
            "K4      非洲史 ",
            "K5      欧洲史",
            "K6      大洋州史",
            "K7      美洲史",
            "K81    传记",
            "K85    文物考古 ",
            "K89    风俗习惯",
            "K9      地理 ",
            "N0      自然科学理论与方法论",
            "N1      自然科学现状及发展 ",
            "N2      自然科学机构、团体、会议",
            "N3      自然科学研究方法 ",
            "N4      自然科学教育与普及",
            "N5      自然科学丛书、文集、连续性出版物",
            "N6      自然科学参考工具书 ",
            "N7      自然科学文献检索工具 ",
            "N8      自然科学调查、考察",
            "N91    自然研究、自然历史 ",
            "N93    非线性科学",
            "N94    系统科学 ",
            "N99    情报学、情报工作 　 ",
            "O1      数学 ",
            "O2      力学",
            "O4      物理学 ",
            "O6      化学 ",
            "O7      晶体学 ",
            "P1      天文学 ",
            "P2      测绘学",
            "P3      地球物理学 ",
            "P4      大气科学（气象学）",
            "P5      地质学",
            "P7      海洋学 ",
            "P9      自然地理学 　 ",
            "Q1      普通生物学",
            "Q2      细胞生物学 ",
            "Q3      遗传学",
            "Q4      生理学 ",
            "Q5      生物化学 ",
            "Q6      生物物理学 ",
            "Q7      分子生物学",
            "Q81     生物工程学（生物技术） ",
            "Q89     环境生物学",
            "Q91     古生物学",
            "Q93     微生物学 ",
            "Q94     植物学",
            "Q95     动物学",
            "Q96     昆虫学",
            "Q98     人类学",
            "R1       预防医学、卫生学",
            "R2       中国医学 ",
            "R3       基础医学",
            "R4       临床医学 ",
            "R5       内科学",
            "R6       外科学 ",
            "R71     妇产科学 ",
            "R72     儿科学",
            "R73     肿瘤学",
            "R74     神经病学和精神病学",
            "R75     皮肤病学与性病学",
            "R76     耳鼻咽喉科学",
            "R77     眼科学",
            "R78     口腔科学 ",
            "R78     外国民族医学 ",
            "R8       特种医学 ",
            "R9       药学 　 ",
            "S1       农业基础科学 ",
            "S2       农业工程 ",
            "S3       农学（农艺学）",
            "S4       植物保护 ",
            "S5       农作物 ",
            "S6       园艺 ",
            "S7       林业",
            "S8       畜牧、动物医学、狩猎、蚕、蜂 ",
            "S9       水产、渔业 ",
            "TB       一般工业技术",
            "TD       矿业工程 ",
            "TE       石油、天然气工业",
            "TF       冶金工业",
            "TG       金属学与金属工艺 ",
            "TH       机械、仪表工业",
            "TJ        武器工业",
            "TK       能源与动力工程 ",
            "TL        原子能技术 ",
            "TM       电工技术 ",
            "TN       无线电电子学、电信技术",
            "TP        自动化技术、计算机技术 ",
            "TQ       化学工业 ",
            "TS       轻工业、手工业 ",
            "TU       建筑科学",
            "TV       水利工程",
            "U1       综合运输",
            "U2       铁路运输",
            "U4       公路运输",
            "U6       水路运输 ",
            "U8       航空运输 　",
            "V1       航空、航天技术的研究与探索 ",
            "V2       航空 ",
            "V4       航天（宇宙航行） ",
            "V7       航空、航天医学 ",
            "X1       环境科学基础理论",
            "X2       社会与环境 ",
            "X3       环境保护管理 ",
            "X4       灾害及其防治",
            "X5       环境污染及其防治 ",
            "X7       废物处理与综合利用 ",
            "X8       环境质量评价与环境监测 ",
            "X9       安全科学 　",
            "Z1       丛书 ",
            "Z2       百科全书、类书",
            "Z3       辞典 ",
            "Z4       论文集、全集、选集、杂著",
            "Z5       年鉴、年刊 ",
            "Z6       期刊、连续性出版物",
            "Z8       图书目录、文摘、索引"});
            this.listBox1.Location = new System.Drawing.Point(64, 419);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(614, 184);
            this.listBox1.TabIndex = 26;
            // 
            // 移送
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 660);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Name = "移送";
            this.Text = "移送";
            this.Load += new System.EventHandler(this.移送_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}