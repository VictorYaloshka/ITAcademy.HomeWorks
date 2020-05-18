using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        const int MaxSpeedDefault = 350;
        private const int MaxSpeedPrivate = 350;
        public const int MaxSpeedPublic = 350;
        protected const int MaxSpeedProtected = 350;
        protected private const int MaxSpeedProtectedPrivate = 350;
        internal const int MaxSpeedInternal = 350;
        protected internal const int MaxSpeedProtectedIntrnal = 350;

        string engineTypeDefault;                               // то же самое, что и private string engineTypeDefault
        private string engineTypePrivate;                       // поле доступно только из текущего класса
        public string engineTypePublic;                         // доступно в любом месте программы, а также для других программ и сборок
        protected string engineTypeProtected;                   // доступно из текущего класса и производных классов
        protected private string engineTypeProtectedPrivate;    // доступно из текущего класса и производных классов, которые определены в этом же проекте
        internal string engineTypeInternal;                     // доступно в любом месте текущего проекта
        protected internal string engineTypeProtectedIntrnal;   // доступно в любом месте текущего проекта и из классов-наследников в других проектах


        void PowerHPtoKwConversionDefault() { }                               // по умолчанию имеет модификатор private
        private void PowerHPtoKwConversionPrivate() { }                       // метод доступен только из текущего класса
        public void PowerHPtoKwConversionPublic() { }                         // доступен в любом месте программы, а также для других программ и сборок
        protected void PowerHPtoKwConversionProtected() { }                   // доступен из текущего класса и производных классов
        protected private void PowerHPtoKwConversionProtectedPrivate() { }    // доступен из текущего класса и производных классов, которые определены в этом же проекте
        internal void PowerHPtoKwConversionInternal() { }                     // доступен в любом месте текущего проекта
        protected internal void PowerHPtoKwConversionProtectedInternal() { }  // доступен в любом месте текущего проекта и из классов-наследников в других проектах


        void Displacement() { }
        private void DisplacementPrivate() { }
        public void DisplacementPublic() { }
        protected void DisplacementProtected() { }
        protected private void DisplacementProtectedPrivate() { }
        internal void DisplacementInternal() { }
        protected internal void DisplacementProtectedInternal() { }

    }
}
