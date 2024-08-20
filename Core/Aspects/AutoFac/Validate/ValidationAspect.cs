using Castle.DynamicProxy;
using Core.CrossCuttingConcern.ValidationTool.FluentValidation;
using Core.Helpers.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.AutoFac.Validate
{
    public class ValidationAspect : MethodInterception
    {
        private readonly Type _validationType;
        public ValidationAspect(Type type)
        {
            if (!typeof(IValidator).IsAssignableFrom(type))
            {
                throw new Exception("This class don`t validation class");
            }

            _validationType = type;
        }

        public override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validationType);
            var entityType = _validationType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidationTool.Validation(validator, entity);
            }

        }
    }
}
