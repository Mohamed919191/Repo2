﻿using BotFactory.Tools;
using System;
using System.Windows.Controls;
using BotFactories.Factories;
using Botfactory.Common.Tools;

namespace BotFactory.Pages
{
    /// <summary>
    /// Interaction logic for FactoryTest.xaml
    /// </summary>
    public partial class FactoryTest : Page
    {
        FactoryDataContext _dataContext = new FactoryDataContext();
        UnitTest _unitTestPage;

        public FactoryTest()
        {
            InitializeComponent();
            DataContext = _dataContext;
        }

        public void SetTestingFactory(UnitFactory factory)
        {
            _dataContext.Builder = factory;
            _dataContext.Builder.FactoryStatus += Builder_FactoryProgress;
        }
        private void Builder_FactoryProgress(object sender, System.EventArgs e)
        {
            _dataContext.ForceUpdate();
        }
        private void AddUnitToQueue_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (ModelsList.SelectedIndex >= 0 && !String.IsNullOrEmpty(UnitName.Text))
            {
                Type item = (Type)ModelsList.SelectedItem;
                var name = UnitName.Text;
                _dataContext.Builder.AddWorkableUnitToQueue(item, name, new Coordinates(0, 0), new Coordinates(10, 10));
                _dataContext.ForceUpdate();
            }
        }
        private void UpdateButtonValidity()
        {
            AddUnitToQueue.IsEnabled = ModelsList.SelectedIndex >= 0 && !String.IsNullOrEmpty(UnitName.Text);
        }

        private void UnitName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateButtonValidity();
        }

        private void ModelsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateButtonValidity();
        }

        private void StorageList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StorageList.SelectedIndex >= 0)
            {
                if (_unitTestPage == null)
                {
                    _unitTestPage = new UnitTest();
                    _unitTestPage.SetUnitToTest((iTestingUnit)StorageList.SelectedItem);
                    UnitFrame.Navigate(_unitTestPage);
                }
                else
                {
                    _unitTestPage.SetUnitToTest((iTestingUnit)StorageList.SelectedItem);
                }
            }
        }
    }
}
