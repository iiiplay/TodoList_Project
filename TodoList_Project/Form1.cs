namespace TodoList_Project
{
    public partial class Form1 : Form
    {
        private List<TodoItem> todos = new List<TodoItem>();
        private string fileName = "todos.txt";

        public Form1()
        {
            InitializeComponent();

            TodoItem item = new TodoItem();
            item.Id = 1;
            item.Title = "去採買!";
            item.IsCompleted = true;
            Console.WriteLine(item);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == string.Empty)
            {
                MessageBox.Show("輸入內容不能為空!", "警告");
                return;
            }


            TodoItem item = new TodoItem();
            item.Id = todos.Count + 1;
            item.Title = txtTitle.Text;

            todos.Add(item);
            lstTodos.Items.Add(item);
            // 清空輸入框
            txtTitle.Text = string.Empty;
        }

        private void lstTodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstTodos.SelectedIndex;
            Console.WriteLine(index);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            int index = lstTodos.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            // 選取到物件
            TodoItem todo = todos[index];
            // !=>not 相反
            todo.IsCompleted = !todo.IsCompleted;
            lstTodos.Items[index] = todo;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstTodos.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            todos.RemoveAt(index);
            RefreshTodoList();

            //lstTodos.Items.RemoveAt(index);
        }

        private void RefreshTodoList()
        {
            //1.清空lstTodos
            lstTodos.Items.Clear();

            //2.循環todos，重新編號
            for (int i = 0; i < todos.Count; i++)
            {
                todos[i].Id = i + 1;
                lstTodos.Items.Add(todos[i]);
            }

            //3.自動選取第一個
            if (todos.Count > 0)
            {
                lstTodos.SelectedIndex = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否確定清空?!", "警告",
                MessageBoxButtons.YesNo);
            // 確定刪除
            if (result == DialogResult.Yes)
            {
                todos.Clear();
                lstTodos.Items.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();

            foreach (TodoItem todo in todos)
            {
                lines.Add(todo.Save());
            }

            File.WriteAllLines(fileName, lines);
            MessageBox.Show($"儲存{fileName}成功!", "訊息");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //清空集合
            todos.Clear();
            lstTodos.Items.Clear();

            //讀取文字檔
            string[] lines = File.ReadAllLines("todos.txt");
            //進行轉換
            foreach(string line in lines)
            {
                TodoItem todo = new TodoItem();
                todos.Add(todo.Load(line));
            }
            //更新listbox
            RefreshTodoList();
            MessageBox.Show($"共讀取{todos.Count}筆資料", "訊息");
        }
    }
}
