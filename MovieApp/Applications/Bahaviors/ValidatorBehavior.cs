using FluentValidation;
using MediatR;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Exceptions;

namespace MovieApp.Applications.Bahaviors
{
    public class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidatorBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var errors = _validators
                .Select(v => v.Validate(request))
                .SelectMany(result => result.Errors)
                .Where(error => error != null)
                .Select(c => new InvalidRequestDTO(c.ErrorCode, c.ErrorMessage))
                .ToList();

            if (errors.Any())
            {
                throw new BadRequestException(errors[0].Code, errors[0].Message);
            }

            return await next();
        }
    }
}
