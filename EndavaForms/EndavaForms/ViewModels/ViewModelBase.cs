﻿using Prism.Mvvm;
using Prism.Navigation;

namespace EndavaForms.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        #region Atributos

        private string _title;

        #endregion

        #region Propiedades

        protected INavigationService NavigationService { get; private set; }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion

        #region Constructor

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        #endregion

        #region Metodos Virtuales

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        #endregion

    }
}
