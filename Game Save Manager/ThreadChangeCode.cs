using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSaveManager
{
    public static class ThreadChangeCode
    {
        private delegate void SetPropertyThreadSafeDelegate<TResult>(Control @this, Expression<Func<TResult>> property, TResult value);

        /// <summary>
        /// <para>Sets the property of a control from a thread where the control *does not* originate.</para>
        /// <para>This was taken from the internet. Call similar to:</para>
        /// <para>myControl.SetPropertyThreadSafe(() => myControl.myProperty, resultingValue)</para>
        /// <see cref="https://stackoverflow.com/a/661706" />
        /// </summary>
        /// <typeparam name="TResult">The type of the property</typeparam>
        /// <param name="this">The control that is being used</param>
        /// <param name="property">The expression for the property to be changed</param>
        /// <param name="value">The value that the propety is the be changed to</param>
        public static void SetPropertyThreadSafe<TResult>(this Control @this, Expression<Func<TResult>> property, TResult value)
        {
            var propertyInfo = (property.Body as MemberExpression).Member as PropertyInfo;

            if (propertyInfo == null ||
                !@this.GetType().IsSubclassOf(propertyInfo.ReflectedType) ||
                @this.GetType().GetProperty(propertyInfo.Name, propertyInfo.PropertyType) == null)
            {
                throw new ArgumentException("The lambda expression 'property' must reference a valid property on this Control.");
            }

            if (@this.InvokeRequired)
            {
                @this.Invoke(new SetPropertyThreadSafeDelegate<TResult>
                (SetPropertyThreadSafe),
                new object[] { @this, property, value });
            }
            else
            {
                @this.GetType().InvokeMember(propertyInfo.Name, BindingFlags.SetProperty, null, @this, new object[] { value });
            }
        }
    }
}
