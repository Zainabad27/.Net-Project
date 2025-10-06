using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zainProject.FieldValidators
{

    public delegate bool FieldValidatorDel(int FieldIndex,string FieldValue, string[] FieldArray,out string FieldInvalidMsg);
    public interface IFieldValidator
    {
        void InitializesValidatorDelegates();

        string[] FieldArray { get;  }

        FieldValidatorDel ValidatorDel { get; }
    }
}
