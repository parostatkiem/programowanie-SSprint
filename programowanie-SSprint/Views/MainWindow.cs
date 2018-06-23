﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    public partial class MainWindow : Form, ImainView, IErrorable
    {

        #region EVENTS
        public event Func<IErrorable, List<company>> getAllCompany;

        public event Func<IErrorable, List<tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
        public event Func<IErrorable, int, order> getSingleOrder; //pobiera jeden order o danym ID

        public event Func<IErrorable, order, bool> insertSingleOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<singleItemOrder>,bool> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. Zwraca bool czy się udało
        #endregion

        #region PUBLIC

        public MainWindow()
        {
            InitializeComponent();
            // THIS IS HOW TO USE ErrorWindow
            //
        }

        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }

        #endregion
        #region GENERATED_EVENTS
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region PRIVATE_VARIABLES_PROPERTIES
        #endregion
        #region PRIVATE_METHODS
        #endregion


    }
}
