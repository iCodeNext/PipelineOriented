using System.Reflection;

namespace PartOneDemo;

public static class PipelineDelegate
{
    public static TOut Pipe<TIn, TOut>(this TIn input,
                                       Func<TIn, TOut> fn)
    {
        return fn(input);
    }


    public static TOut Pipe<TIn, TParam, TOut>(this TIn input,
                                     Func<TIn, TParam, TOut> fn,
                                     TParam param)
    {
        return fn(input, param);
    }
}