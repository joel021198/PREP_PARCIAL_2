using System;
using System.Collections.Generic;
using System.Text;

namespace PAISES.ViewModels
{
   public class CountryViewModel:BaseViewModel
    {
        //api service

        #region Attributes
        private string name;
        private string alpha2code;
        private string capital;
        #endregion

        #region Properties
        public string Name
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
        public string Alpha2Code
        {
            get { return this.alpha2code; }
            set { SetValue(ref this.alpha2code, value); }
        }
        public string Capital
        {
            get { return this.capital; }
            set { SetValue(ref this.capital, value); }
        }
        #endregion

        #region Constructor
        public CountryViewModel()
        {
            this.LoadCountry();
        }
        #endregion

        
        #region Methods        
        private void LoadCountry()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
