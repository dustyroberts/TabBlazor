using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGageUI
{
    public class OffcanvasResult
    {
        public object Data { get; }
        public Type DataType { get; }
        public bool Cancelled { get; }

        internal OffcanvasResult(object data, Type resultType, bool cancelled)
        {
            Data = data;
            DataType = resultType;
            Cancelled = cancelled;
        }

        public static ModalResult Ok() => new ModalResult(default, typeof(object), false);
        public static ModalResult Ok<T>(T result) => new ModalResult(result, typeof(T), false);

        public static ModalResult Cancel() => new ModalResult(default, typeof(object), true);
    }
}
