using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Domain.Common
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;

        public T Value { get; }
        public List<string> Errors { get; }

        private Result(bool isSuccess, T value, List<string> errors)
        {
            IsSuccess = isSuccess;
            Value = value;
            Errors = errors ?? new();
        }

        public static Result<T> Success(T value) =>
            new(true, value, null);

        public static Result<T> Failure(List<string> errors) =>
            new(false, default, errors);

        public static Result<T> Failure(string error) =>
            new(false, default, new List<string> { error });
    }
}
