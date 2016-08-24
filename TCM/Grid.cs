using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace TCM
{
    class Grid
    {
        private static Object formataGrid(DataGridView dt) 
        {
			//permite personalizar o grid
			dt.AutoGenerateColumns = true;
			dt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			//altera a cor das linhas alternadas no grid
			dt.RowsDefaultCellStyle.BackColor = Color.White;
			dt.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			//ao clicar, seleciona a linha inteira
			dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//não permite seleção de multiplas linhas    
			dt.MultiSelect = false;
			//Expande a célula automáticamente
			dt.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			//read only
			dt.ReadOnly = true;
			dt.RowHeadersVisible = false;
			dt.AllowUserToAddRows = false;

            return dt;
        }

        public static Object atualizar_grid(String sql, String pdr, DataGridView dt)
        {
            ClasseConexao conexao = new ClasseConexao();
            DataSet ds = new DataSet();

            if (sql.Equals(null) || sql.Equals(""))
            {
                //placeholder
                sql = pdr;
            }
            ds = conexao.executarSQL(sql);
            dt.DataSource = ds.Tables[0];
            formataGrid(dt);

            return dt;
        }
    }
}
