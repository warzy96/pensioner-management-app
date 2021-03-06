﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;
using DataAccessLayer;
using Model;
using Model.Repositories;
using PresentationLayer;

namespace Controller
{
    public class MainController : IMainController
    {
        private readonly PensionerRepository _pensionerRepository = PensionerRepository.GetInstance();
        private readonly IWindowFormsFactory _formsFactory;
        private MainForm _mainForm;

        public MainController(IWindowFormsFactory factory)
        {
            _formsFactory = factory;
        }

        public void AddPensioner()
        {
            var pensionerController = new PensionerController();

            var addPensionerForm = _formsFactory.CreateAddPensionerForm(pensionerController);

            _pensionerRepository.Attach(_mainForm);

            pensionerController.ShowAddPensionerForm(addPensionerForm);

            _pensionerRepository.Delete(_mainForm);
        }

        public void UpdatePensionerList(IMainForm mainForm)
        {
            _mainForm = (MainForm)mainForm;

            mainForm.UpdatePensionerListView(_pensionerRepository.GetAll());
        }

        public void ShowCreatePdfForm()
        {
            var form = _formsFactory.CreateCreatePdfForm(new FileController());
            form.ShowCreatePdfForm();
        }

        public void ShowPensionerDetailsForm(string oib)
        {
            var pensionerController = new PensionerController();
            var form = _formsFactory.CreatePensionerDetailsForm(pensionerController, oib);

            _pensionerRepository.Attach(_mainForm);

            pensionerController.ShowPensionerDetailsForm(form);

            _pensionerRepository.Delete(_mainForm);
        }

        public void ShowGenerateMutualAidForm()
        {
            var transactionController = new TransactionController();
            var form = _formsFactory.CreateGenerateTransactionsForm(transactionController);

            transactionController.ShowGenerateMutualAidForm(form);
        }

        public void ShowGenerateMembershipForm()
        {
            var transactionController = new TransactionController();
            var form = _formsFactory.CreateGenerateTransactionsForm(transactionController);

            transactionController.ShowGenerateMembershipForm(form);
        }

        public void GetSearchResults(string filter, IMainForm mainForm)
        {
            var allPensioners = _pensionerRepository.GetAll().ToList();
            var searchResult = new List<Pensioner>();
            var filters = filter.Split(' ');
            
            foreach (var pensioner in allPensioners)
            {
                foreach (var data in filters)
                {
                    if (pensioner.Oib.Contains(data)
                        || pensioner.Id.ToString().Contains(data)
                        || pensioner.DateOfBirth.ToString().Contains(data)
                        || pensioner.MembershipStart.ToString().Contains(data)
                        || pensioner.PlaceOfBirth.Contains(data)
                        || pensioner.CurrentAddress.City.Contains(data)
                        || pensioner.CurrentAddress.PostalCode.ToString().Contains(data)
                        || pensioner.CurrentAddress.Street.Contains(data)
                        || pensioner.CurrentAddress.Town.Contains(data)
                        || pensioner.Name.Contains(data)
                        || pensioner.Surname.Contains(data))
                    {
                        searchResult.Add(pensioner);
                    }
                }
            }

            mainForm.UpdatePensionerListView(searchResult);
        }

        public void ShowEditSettingsForm()
        {
            var form = _formsFactory.CreateEditSettingsForm();
            form.ShowForm();
        }
    }
}
