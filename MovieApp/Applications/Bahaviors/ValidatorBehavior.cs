using FluentValidation;
using MediatR;
using MovieApp.DTOs.Exceptions;

namespace MovieApp.Applications.Bahaviors
{
    public class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IValidator<TRequest> _validator;

        public ValidatorBehavior(IValidator<TRequest> validator)
        {
            _validator = validator;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var result = await _validator
                .ValidateAsync(request);

            if (!result.IsValid)
            {
                throw new BadRequestException(result.Errors[0].ErrorCode, result.Errors[0].ErrorMessage);

            }

            return await next();
        }
    }
}
