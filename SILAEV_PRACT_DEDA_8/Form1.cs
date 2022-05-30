using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILAEV_PRACT_DEDA_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // две булевые переменные которые определяют где будет отрисовываться объект
        bool panel = true;
        bool form = false;

        /*
        Button
        CheckBox
        CheckedListBox
        ComboBox
        DataGridView
        DateTimePicker
        DomainUpDown
        FlowLayoutPanel
        GroupBox
        HScrollBar
        Label
        LinkLabel
        ListBox
        ListView
        MaskedTextBox
        MonthCalendar
        NumericUpDown
        Panel
        PictureBox
        PrintPreviewControl
        ProgressBar
        PropertyGrid
        RadioButton
        RichTextBox
        SplitContainer
        TabControl
        TableLayoutPanel
        TextBox
        ToolStripContainer 
        TrackBar
        TreeView
        vScrollBar
        WebBrowser
        */

        // массивы динамически созданных элементов которые
        // при добавлении нового элемента массив увеличивается на 1 элемент, и потом он отрисовывается
        private Button[] arr_Button= new Button[0];
        private CheckBox[] arr_CheckBox = new CheckBox[0];
        private CheckedListBox[] arr_CheckedListBox = new CheckedListBox[0];
        private ComboBox[] arr_ComboBox = new ComboBox[0];
        private DataGridView[] arr_DataGridView = new DataGridView[0];
        private DateTimePicker[] arr_DateTimePicker = new DateTimePicker[0];
        private DomainUpDown[] arr_DomainUpDown = new DomainUpDown[0];
        private FlowLayoutPanel[] arr_FlowLayoutPanel = new FlowLayoutPanel[0];
        private GroupBox[] arr_groupBox = new GroupBox[0];
        private HScrollBar[] arr_HScrollBar = new HScrollBar[0];
        private Label[] arr_Label = new Label[0];
        private LinkLabel[] arr_LinkLabel = new LinkLabel[0];
        private ListBox[] arr_ListBox = new ListBox[0];
        private ListView[] arr_ListView = new ListView[0];
        private MaskedTextBox[] arr_MaskedTextBox = new MaskedTextBox[0];
        private MonthCalendar[] arr_MothCalendar = new MonthCalendar[0];
        private NumericUpDown[] arr_NumericUpDown = new NumericUpDown[0];
        private Panel[] arr_Panel = new Panel[0];
        private PictureBox[] arr_PictureBox = new PictureBox[0];
        private PrintPreviewControl[] arr_PrintPreviewControl = new PrintPreviewControl[0];
        private ProgressBar[] arr_ProgressBar = new ProgressBar[0];
        private PropertyGrid[] arr_PropertyGrid = new PropertyGrid[0];
        private RadioButton[] arr_RadioButton = new RadioButton[0];
        private RichTextBox[] arr_RichTextBox = new RichTextBox[0];
        private SplitContainer[] arr_SplitContainer = new SplitContainer[0];
        private TabControl[] arr_TabControl = new TabControl[0];
        private TableLayoutPanel[] arr_TableLayoutPanel = new TableLayoutPanel[0];
        private TextBox[] arr_TextBox = new TextBox[0];
        private ToolStripContainer[] arr_ToolStripContainer = new ToolStripContainer[0];
        private TrackBar[] arr_TrackBar = new TrackBar[0];
        private TreeView[] arr_TreeView = new TreeView[0];
        private VScrollBar[] arr_VScrollBar = new VScrollBar[0];
        private WebBrowser[] arr_WebBrowser = new WebBrowser[0];

        // группа переменных которая определяет сколько элементов какого либо типа на форме
        private int form_count_Button = 0;
        private int form_count_CheckBox = 0;
        private int form_count_CheckedListBox = 0;
        private int form_count_ComboBox = 0;
        private int form_count_DataGridView = 0;
        private int form_count_DateTimePicker = 0;
        private int form_count_DomainUpDown = 0;
        private int form_count_FlowLayoutPanel = 0;
        private int form_count_GroupBox = 0;
        private int form_count_HScrollBar = 0;
        private int form_count_Label = 0;
        private int form_count_LinkLabel = 0;
        private int form_count_ListBox = 0;
        private int form_count_ListView = 0;
        private int form_count_MaskedTextBox = 0;
        private int form_count_MonthCalendar = 0;
        private int form_count_NumericUpDown = 0;
        private int form_count_Panel = 0;
        private int form_count_PictureBox = 0;
        private int form_count_PrintPreviewControl = 0;
        private int form_count_ProgressBar = 0;
        private int form_count_PropertyGrid = 0;
        private int form_count_RadioButton = 0;
        private int form_count_RichTextBox = 0;
        private int form_count_SplitContainer = 0;
        private int form_count_TabControl = 0;
        private int form_count_TableLayoutPanel = 0;
        private int form_count_TextBox = 0;
        private int form_count_ToolStripContainer = 0;
        private int form_count_TrackBar = 0;
        private int form_count_TreeView = 0;
        private int form_count_vScrollBar = 0;
        private int form_count_WebBrowser = 0;
        private int c = 0;

        // группа переменных которая определяет сколько элементов какого либо типа на панели
        private int panel_count_Button = 0;
        private int panel_count_CheckBox = 0;
        private int panel_count_CheckedListBox = 0;
        private int panel_count_ComboBox = 0;
        private int panel_count_DataGridView = 0;
        private int panel_count_DateTimePicker = 0;
        private int panel_count_DomainUpDown = 0;
        private int panel_count_FlowLayoutPanel = 0;
        private int panel_count_GroupBox = 0;
        private int panel_count_HScrollBar = 0;
        private int panel_count_Label = 0;
        private int panel_count_LinkLabel = 0;
        private int panel_count_ListBox = 0;
        private int panel_count_ListView = 0;
        private int panel_count_MaskedTextBox = 0;
        private int panel_count_MonthCalendar = 0;
        private int panel_count_NumericUpDown = 0;
        private int panel_count_Panel = 0;
        private int panel_count_PictureBox = 0;
        private int panel_count_PrintPreviewControl = 0;
        private int panel_count_ProgressBar = 0;
        private int panel_count_PropertyGrid = 0;
        private int panel_count_RadioButton = 0;
        private int panel_count_RichTextBox = 0;
        private int panel_count_SplitContainer = 0;
        private int panel_count_TabControl = 0;
        private int panel_count_TableLayoutPanel = 0;
        private int panel_count_TextBox = 0;
        private int panel_count_ToolStripContainer = 0;
        private int panel_count_TrackBar = 0;
        private int panel_count_TreeView = 0;
        private int panel_count_vScrollBar = 0;
        private int panel_count_WebBrowser = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1 - Программа начинается с загрузки формы
            // при загрузке формы мы меняем размер самой формы(параметр Width), это сделанно чтобы все элементы уместились на ней(я пытался расширять форму в конструкторе, но при запуске она постоянно была меньше чем надо)
            // далее мы меняем позицию формы на экране(параметр Location) чтобы она уместилась на экран пользователя
            // Далее мы вызываем две функции которые будут описывать свойства уже имеющихся на форме элементов, одна считывает элементы на форме, вторая на панели
            this.Width = 1400;
            this.Location = new Point(10, 10);
            Panel_Controls_Info();
            Form_Controls_Info();
        }

        Random rnd = new Random();

        private void panelNewControl(Control[] arr_c, int c, bool panel, bool form)
        {
            // данная функция вызывается для окончательной отрисовки элемента
            // в функции, переданный в функцию массив увеличивается на 1 , потом идет свитч который определяет какой элемент создавать(он это определяет по числу которое было переданно в функцию
            // далее идут два ифа с булевыми переменными, если переменная "panel" равна true, то переменная отрисуется на панели, если переменная form равна true, то переменная отрисуется на форме
            Array.Resize(ref arr_c, arr_c.Length + 1);
            switch (c)
            {
                case 0:
                    //Button
                    arr_c[arr_c.Length - 1] = new Button();
                    break;
                case 1:
                    //CheckBox
                    arr_c[arr_c.Length - 1] = new CheckBox();
                    break;
                case 2:
                    //CheckedListBox
                    arr_c[arr_c.Length - 1] = new CheckedListBox();
                    break;
                case 3:
                    //ComboBox
                    arr_c[arr_c.Length - 1] = new ComboBox();
                    break;
                case 4:
                    //DataGridView
                    arr_c[arr_c.Length - 1] = new DataGridView();
                    break;
                case 5:
                    //DateTimePicker
                    arr_c[arr_c.Length - 1] = new DateTimePicker();
                    break;
                case 6:
                    //DomainUpDown
                    arr_c[arr_c.Length - 1] = new DomainUpDown();
                    break;
                case 7:
                    //FlowLayoutPanel
                    arr_c[arr_c.Length - 1] = new FlowLayoutPanel();
                    arr_c[arr_c.Length - 1].BackColor = Color.AliceBlue;
                    break;
                case 8:
                    //GroupBox
                    arr_c[arr_c.Length - 1] = new GroupBox();
                    break;
                case 9:
                    //HScrollBar
                    arr_c[arr_c.Length - 1] = new HScrollBar();
                    break;
                case 10:
                    //Label
                    arr_c[arr_c.Length - 1] = new Label();
                    arr_c[arr_c.Length - 1].Text = "Label" + (form_count_Label + panel_count_Label-1).ToString();
                    break;
                case 11:
                    //LinkLabel
                    arr_c[arr_c.Length - 1] = new LinkLabel();
                    arr_c[arr_c.Length - 1].Text = "LinkLabel" + (form_count_Label + panel_count_Label - 1).ToString();
                    break;
                case 12:
                    //ListBox
                    arr_c[arr_c.Length - 1] = new ListBox();
                    break;
                case 13:
                    //ListView
                    arr_c[arr_c.Length - 1] = new ListView();
                    break;
                case 14:
                    //MaskedTextBox
                    arr_c[arr_c.Length - 1] = new MaskedTextBox();
                    break;
                case 15:
                    //MonthCalendar
                    arr_c[arr_c.Length - 1] = new MonthCalendar();
                    break;
                case 16:
                    //NumericUpDown
                    arr_c[arr_c.Length - 1] = new WebBrowser();
                    break;
                case 17:
                    //Panel
                    arr_c[arr_c.Length - 1] = new Panel();
                    arr_c[arr_c.Length - 1].BackColor = Color.AliceBlue;
                    break;
                case 18:
                    //PictureBox
                    arr_c[arr_c.Length - 1] = new PictureBox();
                    arr_c[arr_c.Length - 1].BackColor = Color.AliceBlue;
                    break;
                case 19:
                    //PrintPreviewControl
                    arr_c[arr_c.Length - 1] = new PrintPreviewControl();
                    break;
                case 20:
                    //ProgressBar
                    arr_c[arr_c.Length - 1] = new ProgressBar();
                    break;
                case 21:
                    //PropertyGrid
                    arr_c[arr_c.Length - 1] = new PropertyGrid();
                    break;
                case 22:
                    //RadioButton
                    arr_c[arr_c.Length - 1] = new RadioButton();
                    break;
                case 23:
                    //RichTextBox
                    arr_c[arr_c.Length - 1] = new RichTextBox();
                    break;
                case 24:
                    //SplitContainer
                    arr_c[arr_c.Length - 1] = new SplitContainer();
                    arr_c[arr_c.Length - 1].BackColor = Color.AliceBlue;
                    break;
                case 25:
                    //TabControl
                    arr_c[arr_c.Length - 1] = new TabControl();
                    break;
                case 26:
                    //TableLayoutPanel
                    arr_c[arr_c.Length - 1] = new TableLayoutPanel();
                    arr_c[arr_c.Length - 1].BackColor = Color.AliceBlue;
                    break;
                case 27:
                    //TextBox
                    arr_c[arr_c.Length - 1] = new TextBox();
                    break;
                case 28:
                    //ToolStripContainer
                    arr_c[arr_c.Length - 1] = new ToolStripContainer();
                    arr_c[arr_c.Length - 1].BackColor = Color.AliceBlue;
                    break;
                case 29:
                    //TrackBar
                    arr_c[arr_c.Length - 1] = new TrackBar();
                    break;
                case 30:
                    //TreeView
                    arr_c[arr_c.Length - 1] = new TreeView();
                    break;
                case 31:
                    //vScrollBar
                    arr_c[arr_c.Length - 1] = new VScrollBar();
                    break;
                case 32:
                    //WebBrowser
                    arr_c[arr_c.Length - 1] = new WebBrowser();
                    break;
                default:
                    break;
            }
            if (panel)
            {
                // генерируется положение элемента рандомным образом
                arr_c[arr_c.Length - 1].Location = new Point(rnd.Next(0, panel1.Width - 20), rnd.Next(0, panel1.Height - 20));
                // генерируется размер элемента рандомным образом
                arr_c[arr_c.Length - 1].Size = new Size(rnd.Next(20, panel1.Width - arr_c[arr_c.Length - 1].Location.X), rnd.Next(20, panel1.Height - arr_c[arr_c.Length - 1].Location.Y));
                panel1.Controls.Add(arr_c[arr_c.Length - 1]);
            }
            if (form)
            {
                // генерируется положение элемента рандомным образом
                arr_c[arr_c.Length - 1].Location = new Point(rnd.Next(panel1.Width + panel1.Location.X+10, richTextBox1.Location.X - 10), rnd.Next(panel1.Location.Y + 10, panel1.Height + panel1.Location.Y - 10));
                // генерируется размер элемента рандомным образом
                arr_c[arr_c.Length - 1].Size = new Size(rnd.Next(10, richTextBox1.Location.X - arr_c[arr_c.Length - 1].Location.X), rnd.Next(10, (panel1.Height + panel1.Location.Y) - arr_c[arr_c.Length - 1].Location.Y));
                Controls.Add(arr_c[arr_c.Length - 1]);
            }
            // элемент переходит на 1 план на форме или на панели
            arr_c[arr_c.Length - 1].BringToFront();
        }

        private void NewControlAllForm(bool panel,bool form)
        {
            // функция вызывается при создании нового обьекта
            // далее рандомайзером Random - "rnd" который был создан выше по коду генерируется число от 0 до 32
            // далее данное число попадает в swith и уже в свиче вызывется функция которая окончательно будет отрисовывать элемент
            // в функцию передаются массив который был создан динамически выше, само число которое было сгенерированно(оно понадобиться в следующей функции) и две булевые переменные которые будут определять где будет отрисовываться элемент
            int temp = rnd.Next(33);
            switch (temp)
            {
                case 0:
                    //Button
                    panelNewControl(arr_Button, temp, panel, form);
                    break;
                case 1:
                    //CheckBox
                    panelNewControl(arr_CheckBox, temp, panel, form);
                    break;
                case 2:
                    //CheckedListBox
                    panelNewControl(arr_CheckedListBox, temp, panel, form);
                    break;
                case 3:
                    //ComboBox
                    panelNewControl(arr_ComboBox, temp, panel, form);
                    break;
                case 4:
                    //DataGridView
                    panelNewControl(arr_DataGridView, temp, panel, form);
                    break;
                case 5:
                    //DateTimePicker
                    panelNewControl(arr_DateTimePicker, temp, panel, form);
                    break;
                case 6:
                    //DomainUpDown
                    panelNewControl(arr_DomainUpDown, temp, panel, form);


                    break;
                case 7:
                    //FlowLayoutPanel
                    panelNewControl(arr_FlowLayoutPanel, temp, panel, form);
                    break;
                case 8:
                    //GroupBox
                    panelNewControl(arr_groupBox, temp, panel, form);
                    break;
                case 9:
                    //HScrollBar
                    panelNewControl(arr_HScrollBar, temp, panel, form);
                    break;
                case 10:
                    //Label
                    panelNewControl(arr_Label, temp, panel, form);
                    break;
                case 11:
                    //LinkLabel
                    panelNewControl(arr_LinkLabel, temp, panel, form);
                    break;
                case 12:
                    //ListBox
                    panelNewControl(arr_ListBox, temp, panel, form);
                    break;
                case 13:
                    //ListView
                    panelNewControl(arr_ListView, temp, panel, form);
                    break;
                case 14:
                    //MaskedTextBox
                    panelNewControl(arr_MaskedTextBox, temp, panel, form);
                    break;
                case 15:
                    //MonthCalendar
                    panelNewControl(arr_MothCalendar, temp, panel, form);
                    break;
                case 16:
                    //NumericUpDown
                    panelNewControl(arr_NumericUpDown, temp, panel, form);
                    break;
                case 17:
                    //Panel
                    panelNewControl(arr_Panel, temp, panel, form);
                    break;
                case 18:
                    //PictureBox
                    panelNewControl(arr_PictureBox, temp, panel, form);
                    break;
                case 19:
                    //PrintPreviewControl
                    panelNewControl(arr_PrintPreviewControl, temp, panel, form);
                    break;
                case 20:
                    //ProgressBar
                    panelNewControl(arr_ProgressBar, temp, panel, form);
                    break;
                case 21:
                    //PropertyGrid
                    panelNewControl(arr_PropertyGrid, temp, panel, form);
                    break;
                case 22:
                    //RadioButton
                    panelNewControl(arr_RadioButton, temp, panel, form);
                    break;
                case 23:
                    //RichTextBox
                    panelNewControl(arr_RichTextBox, temp, panel, form);
                    break;
                case 24:
                    //SplitContainer
                    panelNewControl(arr_SplitContainer, temp, panel, form);
                    break;
                case 25:
                    //TabControl
                    panelNewControl(arr_TabControl, temp, panel, form);
                    break;
                case 26:
                    //TableLayoutPanel
                    panelNewControl(arr_TableLayoutPanel, temp, panel, form);
                    break;
                case 27:
                    //TextBox
                    panelNewControl(arr_TextBox, temp, panel, form);
                    break;
                case 28:
                    //ToolStripContainer
                    panelNewControl(arr_ToolStripContainer, temp, panel, form);
                    break;
                case 29:
                    //TrackBar
                    panelNewControl(arr_TrackBar, temp, panel, form);
                    break;
                case 30:
                    //TreeView
                    panelNewControl(arr_TreeView, temp, panel, form);
                    break;
                case 31:
                    //vScrollBar
                    panelNewControl(arr_VScrollBar, temp, panel, form);
                    break;
                case 32:
                    //WebBrowser
                    panelNewControl(arr_WebBrowser, temp, panel, form);
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // при нажатии на первую кнопку вызывается данная функция
            // в функции есть два переключения булевых переменных, которые переключаются таким образом чтобы была верной только переменная panel
            // далее вызывается функция создания и отрисовки нового элемента в которой будет определено где будет отрисовываться новый элемент, на форме или на панели
            panel = true;
            form = false;
            // Panel
            NewControlAllForm(panel,form);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // при нажатии на вторую кнопку вызывается данная функция
            // в функции есть два переключения булевых переменных, которые переключаются таким образом чтобы была верной только переменная form
            // далее вызывается функция создания и отрисовки нового элемента в которой будет определено где будет отрисовываться новый элемент, на форме или на панели
            // Form
            panel = false;
            form = true;
            NewControlAllForm(panel, form);
        }

        private void panelControlInf(string name, ref int ContrlCount, IEnumerable<Control> panel)
        {
            // вывод информаци  о элементе на панели на второй ричтекстбокс
            // в функции есть внутрений счетчик "с"
            // а также внешний счетчик который передается по ссылке
            c = 0;
            ContrlCount = 0;
            foreach (var item in panel)
            {
                ContrlCount++;
                c++;
                richTextBox2.Text += c + " " + name + "\n\n";
                richTextBox2.Text += "\tLocation\t\t\t\t" + item.Location + "\n";
                richTextBox2.Text += "\tSize\t\t\t\t" + item.Size + "\n";
                richTextBox2.Text += "\n";
            }
            richTextBox2.Text += "\n";
            c = 0;
        }

        private void ControlInf(string name, ref int ContrlCount, IEnumerable<Control> control)
        {
            // вывод информаци  о элементе на форме на первый ричтекстбокс 
            // в функции есть внутрений счетчик "с"
            // а также внешний счетчик который передается по ссылке
            c = 0;
            ContrlCount = 0;
            foreach (var item in control)
            {
                ContrlCount++;
                c++;
                richTextBox1.Text += c + " " + name + "\n\n";
                richTextBox1.Text += "\tLocation\t\t\t\t" + item.Location + "\n";
                richTextBox1.Text += "\tSize\t\t\t\t" + item.Size + "\n";
                richTextBox1.Text += "\n";
            }
            richTextBox1.Text += "\n";
            c = 0;
        }

        private void Panel_Controls_Info()
        {
            // функция которая описывает свойства о элементах на панели в второй ричтекстбокс
            // функция содержит много ифов, они нужны для того чтобы функция вывода информации не вызывалась для тех групп элементов которые вообще отсутствуют на панели(это было сделанно потому что при выводе описания о элементах, появлялись лишние пробелы)
            // данные передаваемые в функцию, это строка с названием элемента, ссылка на переменную которая будет считать элементы на форме, и группу элементов которые принадленат к группе каких либо элементов(например группа кнопок, или тестбоксов)
            richTextBox2.Clear();
            richTextBox2.Text += "Controls on Panel\n\n";
            if (panel1.Controls.OfType<Button>().Count() != 0)
            {
                panelControlInf("Button", ref panel_count_Button, panel1.Controls.OfType<Button>());
            }
            if (panel1.Controls.OfType<CheckBox>().Count() != 0) {
                panelControlInf("CheckBox", ref panel_count_CheckBox, panel1.Controls.OfType<CheckBox>());
            }
            if (panel1.Controls.OfType<CheckedListBox>().Count() != 0)
            {
                panelControlInf("CheckedListBox", ref panel_count_CheckedListBox, panel1.Controls.OfType<CheckedListBox>());
            }
            if (panel1.Controls.OfType<ComboBox>().Count() != 0)
            { 
                panelControlInf("ComboBox", ref panel_count_ComboBox, panel1.Controls.OfType<ComboBox>());
            }
            if (panel1.Controls.OfType<DataGridView>().Count() != 0)
            {
                panelControlInf("DataGridView", ref panel_count_DataGridView, panel1.Controls.OfType<DataGridView>());
            }
            if (panel1.Controls.OfType<DateTimePicker>().Count() != 0)
            {
                panelControlInf("DateTimePicker", ref panel_count_DateTimePicker, panel1.Controls.OfType<DateTimePicker>());
            }
            if (panel1.Controls.OfType<DomainUpDown>().Count() != 0)
            {
                panelControlInf("DomainUpDown", ref panel_count_DomainUpDown, panel1.Controls.OfType<DomainUpDown>());
            }
            if (panel1.Controls.OfType<FlowLayoutPanel>().Count() != 0)
            {
                panelControlInf("FlowLayoutPanel", ref panel_count_FlowLayoutPanel, panel1.Controls.OfType<FlowLayoutPanel>());
            }
            if (panel1.Controls.OfType<GroupBox>().Count() != 0)
            {
                panelControlInf("GroupBox", ref panel_count_GroupBox, panel1.Controls.OfType<GroupBox>());
            }
            if (panel1.Controls.OfType<HScrollBar>().Count() != 0)
            {
                panelControlInf("HScrollBar", ref panel_count_HScrollBar, panel1.Controls.OfType<HScrollBar>());
            }
            if (panel1.Controls.OfType<Label>().Count() != 0)
            {
                panelControlInf("Label", ref panel_count_Label, panel1.Controls.OfType<Label>());
            }
            if (panel1.Controls.OfType<LinkLabel>().Count() != 0)
            {
                panelControlInf("LinkLabel", ref panel_count_LinkLabel, panel1.Controls.OfType<LinkLabel>());
            }
            if (panel1.Controls.OfType<ListBox>().Count() != 0)
            {
                panelControlInf("ListBox", ref panel_count_ListBox, panel1.Controls.OfType<ListBox>());
            }
            if (panel1.Controls.OfType<ListView>().Count() != 0)
            {
                panelControlInf("ListView", ref panel_count_ListView, panel1.Controls.OfType<ListView>());
            }
            if (panel1.Controls.OfType<MaskedTextBox>().Count() != 0)
            {
                panelControlInf("MaskedTextBox", ref panel_count_MaskedTextBox, panel1.Controls.OfType<MaskedTextBox>());
            }
            if (panel1.Controls.OfType<MonthCalendar>().Count() != 0)
            {
                panelControlInf("MonthCalendar", ref panel_count_MonthCalendar, panel1.Controls.OfType<MonthCalendar>());
            }
            if (panel1.Controls.OfType<NumericUpDown>().Count() != 0)
            {
                panelControlInf("NumericUpDown", ref panel_count_NumericUpDown, panel1.Controls.OfType<NumericUpDown>());
            }
            if (panel1.Controls.OfType<Panel>().Count() != 0)
            {
                panelControlInf("Panel", ref panel_count_Panel, panel1.Controls.OfType<Panel>());
            }
            if (panel1.Controls.OfType<PictureBox>().Count() != 0)
            {
                panelControlInf("PictureBox", ref panel_count_PictureBox, panel1.Controls.OfType<PictureBox>());
            }
            if (panel1.Controls.OfType<PrintPreviewControl>().Count() != 0)
            {
                panelControlInf("PrintPreviewControl", ref panel_count_PrintPreviewControl, panel1.Controls.OfType<PrintPreviewControl>());
            }
            if (panel1.Controls.OfType<ProgressBar>().Count() != 0)
            {
                panelControlInf("ProgressBar", ref panel_count_ProgressBar, panel1.Controls.OfType<ProgressBar>());
            }
            if (panel1.Controls.OfType<PropertyGrid>().Count() != 0)
            {
                panelControlInf("PropertyGrid", ref panel_count_PropertyGrid, panel1.Controls.OfType<PropertyGrid>());
            }
            if (panel1.Controls.OfType<RadioButton>().Count() != 0)
            {
                panelControlInf("RadioButton", ref panel_count_RadioButton, panel1.Controls.OfType<RadioButton>());
            }
            if (panel1.Controls.OfType<RichTextBox>().Count() != 0)
            {
                panelControlInf("RichTextBox", ref panel_count_RichTextBox, panel1.Controls.OfType<RichTextBox>());
            }
            if (panel1.Controls.OfType<SplitContainer>().Count() != 0)
            {
                panelControlInf("SplitContainer", ref panel_count_SplitContainer, panel1.Controls.OfType<SplitContainer>());
            }
            if (panel1.Controls.OfType<TabControl>().Count() != 0)
            {
                panelControlInf("TabControl", ref panel_count_TabControl, panel1.Controls.OfType<TabControl>());
            }
            if (panel1.Controls.OfType<TableLayoutPanel>().Count() != 0)
            {
                panelControlInf("TableLayoutPanel", ref panel_count_TableLayoutPanel, panel1.Controls.OfType<TableLayoutPanel>());
            }
            if (panel1.Controls.OfType<TextBox>().Count() != 0)
            {
                panelControlInf("TextBox", ref panel_count_TextBox, panel1.Controls.OfType<TextBox>());
            }
            if (panel1.Controls.OfType<ToolStripContainer>().Count() != 0)
            {
                panelControlInf("ToolStripContainer", ref panel_count_ToolStripContainer, panel1.Controls.OfType<ToolStripContainer>());
            }
            if (panel1.Controls.OfType<TrackBar>().Count() != 0)
            {
                panelControlInf("TrackBar", ref panel_count_TrackBar, panel1.Controls.OfType<TrackBar>());
            }
            if (panel1.Controls.OfType<TreeView>().Count() != 0)
            {
                panelControlInf("TreeView", ref panel_count_TreeView, panel1.Controls.OfType<TreeView>());
            }
            if (panel1.Controls.OfType<VScrollBar>().Count() != 0)
            {
                panelControlInf("VScrollBar", ref panel_count_vScrollBar, panel1.Controls.OfType<VScrollBar>());
            }
            if (panel1.Controls.OfType<WebBrowser>().Count() != 0)
            {
                panelControlInf("WebBrowser", ref panel_count_WebBrowser, panel1.Controls.OfType<WebBrowser>());
            }
        }

        private void Form_Controls_Info()
        {
            // функция которая описывает свойства о элементах на форме в первый ричтекстбокс
            // функция содержит много ифов, они нужны для того чтобы функция вывода информации не вызывалась для тех групп элементов которые вообще отсутствуют на панели(это было сделанно потому что при выводе описания о элементах, появлялись лишние пробелы)
            // данные передаваемые в функцию, это строка с названием элемента, ссылка на переменную которая будет считать элементы на форме, и группу элементов которые принадленат к группе каких либо элементов(например группа кнопок, или тестбоксов)
            // 3
            richTextBox1.Clear();
            richTextBox1.Text += "Controls on Form\n\n";
            if (Controls.OfType<Button>().Count() != 0)
            {
                ControlInf("Button", ref form_count_Button, Controls.OfType<Button>());
            }
            if (Controls.OfType<CheckBox>().Count() != 0)
            {
                ControlInf("CheckBox", ref form_count_CheckBox, Controls.OfType<CheckBox>());
            }
            if (Controls.OfType<CheckedListBox>().Count() != 0)
            {
                ControlInf("CheckedListBox", ref form_count_CheckedListBox, Controls.OfType<CheckedListBox>());
            }
            if (Controls.OfType<ComboBox>().Count() != 0)
            {
                ControlInf("ComboBox", ref form_count_ComboBox, Controls.OfType<ComboBox>());
            }
            if (Controls.OfType<DataGridView>().Count() != 0)
            {
                ControlInf("DataGridView", ref form_count_DataGridView, Controls.OfType<DataGridView>());
            }
            if (Controls.OfType<DateTimePicker>().Count() != 0)
            {
                ControlInf("DateTimePicker", ref form_count_DateTimePicker, Controls.OfType<DateTimePicker>());
            }
            if (Controls.OfType<DomainUpDown>().Count() != 0)
            {
                ControlInf("DomainUpDown", ref form_count_DomainUpDown, Controls.OfType<DomainUpDown>());
            }
            if (Controls.OfType<FlowLayoutPanel>().Count() != 0)
            {
                ControlInf("FlowLayoutPanel", ref form_count_FlowLayoutPanel, Controls.OfType<FlowLayoutPanel>());
            }
            if (Controls.OfType<GroupBox>().Count() != 0)
            {
                ControlInf("GroupBox", ref form_count_GroupBox, Controls.OfType<GroupBox>());
            }
            if (Controls.OfType<HScrollBar>().Count() != 0)
            {
                ControlInf("HScrollBar", ref form_count_HScrollBar, Controls.OfType<HScrollBar>());
            }
            if (Controls.OfType<Label>().Count() != 0)
            {
                ControlInf("Label", ref form_count_Label, Controls.OfType<Label>());
            }
            if (Controls.OfType<LinkLabel>().Count() != 0)
            {
                ControlInf("LinkLabel", ref form_count_LinkLabel, Controls.OfType<LinkLabel>());
            }
            if (Controls.OfType<ListBox>().Count() != 0)
            {
                ControlInf("ListBox", ref form_count_ListBox, Controls.OfType<ListBox>());
            }
            if (Controls.OfType<ListView>().Count() != 0)
            {
                ControlInf("ListView", ref form_count_ListView, Controls.OfType<ListView>());
            }
            if (Controls.OfType<MaskedTextBox>().Count() != 0)
            {
                ControlInf("MaskedTextBox", ref form_count_MaskedTextBox, Controls.OfType<MaskedTextBox>());
            }
            if (Controls.OfType<MonthCalendar>().Count() != 0)
            {
                ControlInf("MonthCalendar", ref form_count_MonthCalendar, Controls.OfType<MonthCalendar>());
            }
            if (Controls.OfType<NumericUpDown>().Count() != 0)
            {
                ControlInf("NumericUpDown", ref form_count_NumericUpDown, Controls.OfType<NumericUpDown>());
            }
            if (Controls.OfType<Panel>().Count() != 0)
            {
                ControlInf("Panel", ref form_count_Panel, Controls.OfType<Panel>());
            }
            if (Controls.OfType<PictureBox>().Count() != 0)
            {
                ControlInf("PictureBox", ref form_count_PictureBox, Controls.OfType<PictureBox>());
            }
            if (Controls.OfType<PrintPreviewControl>().Count() != 0)
            {
                ControlInf("PrintPreviewControl", ref form_count_PrintPreviewControl, Controls.OfType<PrintPreviewControl>());
            }
            if (Controls.OfType<ProgressBar>().Count() != 0)
            {
                ControlInf("ProgressBar", ref form_count_ProgressBar, Controls.OfType<ProgressBar>());
            }
            if (Controls.OfType<PropertyGrid>().Count() != 0)
            {
                ControlInf("PropertyGrid", ref form_count_PropertyGrid, Controls.OfType<PropertyGrid>());
            }
            if (Controls.OfType<RadioButton>().Count() != 0)
            {
                ControlInf("RadioButton", ref form_count_RadioButton, Controls.OfType<RadioButton>());
            }
            if (Controls.OfType<RichTextBox>().Count() != 0)
            {
                ControlInf("RichTextBox", ref form_count_RichTextBox, Controls.OfType<RichTextBox>());
            }
            if (Controls.OfType<SplitContainer>().Count() != 0)
            {
                ControlInf("SplitContainer", ref form_count_SplitContainer, Controls.OfType<SplitContainer>());
            }
            if (Controls.OfType<TabControl>().Count() != 0)
            {
                ControlInf("TabControl", ref form_count_TabControl, Controls.OfType<TabControl>());
            }
            if (Controls.OfType<TableLayoutPanel>().Count() != 0)
            {
                ControlInf("TableLayoutPanel", ref form_count_TableLayoutPanel, Controls.OfType<TableLayoutPanel>());
            }
            if (Controls.OfType<TextBox>().Count() != 0)
            {
                ControlInf("TextBox", ref form_count_TextBox, Controls.OfType<TextBox>());
            }
            if (Controls.OfType<ToolStripContainer>().Count() != 0)
            {
                ControlInf("ToolStripContainer", ref form_count_ToolStripContainer, Controls.OfType<ToolStripContainer>());
            }
            if (Controls.OfType<TrackBar>().Count() != 0)
            {
                ControlInf("TrackBar", ref form_count_TrackBar, Controls.OfType<TrackBar>());
            }
            if (Controls.OfType<TreeView>().Count() != 0)
            {
                ControlInf("TreeView", ref form_count_TreeView, Controls.OfType<TreeView>());
            }
            if (Controls.OfType<VScrollBar>().Count() != 0)
            {
                ControlInf("VScrollBar", ref form_count_vScrollBar, Controls.OfType<VScrollBar>());
            }
            if (Controls.OfType<WebBrowser>().Count() != 0)
            {
                ControlInf("WebBrowser", ref form_count_WebBrowser, Controls.OfType<WebBrowser>());
            }
        }


        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
            // Данная функция определяет, был ли добавлен на форму новый элемент, сразу же как новый элемент появляется на форме, то вызывается эта функция
            // Данная вызывает другую функцию(эту же функцию мы вызывали при загрузке формы), которая в свою очередь переписывает информацию о свойствах элементов на форме в 1 picturebox'e
            Form_Controls_Info();
        }

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            // Данная функция определяет, был ли добавлен на панель новый элемент, сразу же как новый элемент появляется на панели, то вызывается эта функция
            // Данная вызывает другую функцию(эту же функцию мы вызывали при загрузке формы), которая в свою очередь переписывает информацию о свойствах элементов на панели в 2 picturebox'e
            Panel_Controls_Info();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // При нажатии кнопки "справка" откроется новое окно с сообщением, которое выведет информацию о количестве элементов на форме и на панели
            MessageBox.Show("Panel\tForm\tName\n"+
                            panel_count_Button.ToString() + "\t" + form_count_Button.ToString() + "\tButton\n" +
                            panel_count_CheckBox.ToString() + "\t" + form_count_CheckBox.ToString() + "\tCheckBox\n" +
                            panel_count_ComboBox.ToString() + "\t" + form_count_ComboBox.ToString() + "\tComboBox\n" +
                            panel_count_DataGridView.ToString() + "\t" + form_count_DataGridView.ToString() + "\tDataGridView\n" +
                            panel_count_DateTimePicker.ToString() + "\t" + form_count_DateTimePicker.ToString() + "\tDateTimePicker\n" +
                            panel_count_DomainUpDown.ToString() + "\t" + form_count_DomainUpDown.ToString() + "\tDomainUpDown\n" +
                            panel_count_FlowLayoutPanel.ToString() + "\t" + form_count_FlowLayoutPanel.ToString() + "\tFlowLayoutPanel\n" +
                            panel_count_GroupBox.ToString() + "\t" + form_count_GroupBox.ToString() + "\tGroupBox\n" +
                            panel_count_HScrollBar.ToString() + "\t" + form_count_HScrollBar.ToString() + "\tHScrollBar\n" +
                            panel_count_Label.ToString() + "\t" + form_count_Label.ToString() + "\tLabel\n" +
                            panel_count_LinkLabel.ToString() + "\t" + form_count_LinkLabel.ToString() + "\tLinkLabel\n" +
                            panel_count_ListBox.ToString() + "\t" + form_count_ListBox.ToString() + "\tListBox\n" +
                            panel_count_ListView.ToString() + "\t" + form_count_ListView.ToString() + "\tListView\n" +
                            panel_count_MaskedTextBox.ToString() + "\t" + form_count_MaskedTextBox.ToString() + "\tMaskedTextBox\n" +
                            panel_count_MonthCalendar.ToString() + "\t" + form_count_MonthCalendar.ToString() + "\tMonthCalendar\n" +
                            panel_count_NumericUpDown.ToString() + "\t" + form_count_NumericUpDown.ToString() + "\tNumericUpDown\n" +
                            panel_count_Panel.ToString() + "\t" + form_count_Panel.ToString() + "\tPanel\n" +
                            panel_count_PictureBox.ToString() + "\t" + form_count_PictureBox.ToString() + "\tPictureBox\n" +
                            panel_count_PrintPreviewControl.ToString() + "\t" + form_count_PrintPreviewControl.ToString() + "\tPrintPreviewControl\n" +
                            panel_count_ProgressBar.ToString() + "\t" + form_count_ProgressBar.ToString() + "\tProgressBar\n" +
                            panel_count_PropertyGrid.ToString() + "\t" + form_count_PropertyGrid.ToString() + "\tPropertyGrid\n" +
                            panel_count_RadioButton.ToString() + "\t" + form_count_RadioButton.ToString() + "\tRadioButton\n" +
                            panel_count_RichTextBox.ToString() + "\t" + form_count_RichTextBox.ToString() + "\tRichTextBox\n" +
                            panel_count_SplitContainer.ToString() + "\t" + form_count_SplitContainer.ToString() + "\tSplitContainer\n" +
                            panel_count_TabControl.ToString() + "\t" + form_count_TabControl.ToString() + "\tTabControl\n" +
                            panel_count_TableLayoutPanel.ToString() + "\t" + form_count_TableLayoutPanel.ToString() + "\tTableLayoutPanel\n" +
                            panel_count_TextBox.ToString() + "\t" + form_count_TextBox.ToString() + "\tTextBox\n" +
                            panel_count_ToolStripContainer.ToString() + "\t" + form_count_ToolStripContainer.ToString() + "\tToolStripContainer\n" +
                            panel_count_TrackBar.ToString() + "\t" + form_count_TrackBar.ToString() + "\tTrackBar\n" +
                            panel_count_TreeView.ToString() + "\t" + form_count_TreeView.ToString() + "\tTreeView\n" +
                            panel_count_vScrollBar.ToString() + "\t" + form_count_vScrollBar.ToString() + "\tvScrollBar\n" +
                            panel_count_WebBrowser.ToString() + "\t" + form_count_WebBrowser.ToString() + "\tWebBrowser\n");
        }

    }
}
