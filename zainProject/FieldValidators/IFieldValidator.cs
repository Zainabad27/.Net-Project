using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zainProject.FieldValidators
{

    public delegate bool FieldValidatorDelegateInterface(int FieldIndex,string FieldValue, string[] FieldArray,out string FieldInvalidMsg);
    public interface IFieldValidator
    {
        void InitializesValidatorDelegates();

        public string[] FieldArray { get; }

        FieldValidatorDelegateInterface ValidatorDel { get; }
    }
}
