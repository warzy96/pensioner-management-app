﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib;
using Model;
using PresentationLayer;

namespace Controller
{
    public class MainController : IMainController
    {
        private readonly PensionerRepository _pensionerRepository = PensionerRepository.GetInstance();

        public MainController()
        {
        }

        public void AddPensioner()
        {
            var addPensionerForm = new AddPensionerForm(_pensionerRepository);
            addPensionerForm.ShowDialog();
        }
    }
}
