using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_20_Delegate_02.Models
{
    delegate void VSExtInit();
    internal class VisualStudioCode
    {
        private List<VSCodeExtension> _extensions = new();
        private VSExtInit _initMethods;
        private VSExtInit _stopMethods;

        public void AjouterExtension(VSCodeExtension ext)
        {
            if (_extensions.Contains(ext)) throw new InvalidOperationException("Cette extension est déjà installée.");
            _extensions.Add(ext);
            _initMethods += ext.Init;
            _stopMethods += ext.Arret;
        }

        public void DisableExtension(VSCodeExtension ext)
        {
            if(!_extensions.Contains(ext)) throw new InvalidOperationException("Cette extension n'est pas installée.");
            _initMethods -= ext.Init;
            RestartExtensions();
            _stopMethods -= ext.Arret;
        }
        public void EnableExtension(VSCodeExtension ext)
        {
            if (!_extensions.Contains(ext)) throw new InvalidOperationException("Cette extension n'est pas installée.");
            _initMethods += ext.Init;
            RestartExtensions();
            _stopMethods += ext.Arret;
        }

        public void DemarrerVSCode()
        {
            //foreach (VSCodeExtension ext in _extensions)
            //{
            //    ext.Init();
            //}
            _initMethods?.Invoke();
        }

        public void RestartExtensions()
        {
            _stopMethods?.Invoke();
            _initMethods?.Invoke();
        }
    }
}
