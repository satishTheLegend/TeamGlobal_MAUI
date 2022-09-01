using TeamGlobal.ViewModels;

namespace TeamGlobal.Views;

public partial class Login : ContentPage
{
	#region Properties
	private readonly LoginViewModel _vm;
    #endregion

    #region Constructor
    public Login()
	{
		InitializeComponent();
		_vm = new LoginViewModel();
		BindingContext = _vm;
	}
	#endregion

	#region Override Methods

	#endregion

	#region Event Handlers

	#endregion

	#region Public Methods

	#endregion

}