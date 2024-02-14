namespace NGageUI {
    public class ReCaptchaStateService
    {
        private bool _isReCaptchaValidated = false;
        public event Action OnChange;

        public bool IsReCaptchaValidated
        {
            get => _isReCaptchaValidated;
            set
            {
                _isReCaptchaValidated = value;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
