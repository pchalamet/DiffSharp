namespace DiffSharp.Distributions
open DiffSharp
open DiffSharp.Util

[<AbstractClass>]
type Distribution() =
    abstract member Sample: unit -> Tensor
    member d.Sample(?numSamples:int) =
        let numSamples = defaultArg numSamples -1
        if numSamples = -1 then
            d.Sample()
        else
            List.init numSamples (fun _ -> d.Sample()) |> Tensor.Stack
    abstract member Mean: Tensor
    abstract member Stddev : Tensor
    member d.Variance = d.Stddev * d.Stddev

type Uniform(low:Tensor, high:Tensor) =
    inherit Distribution()
    do if low.Shape <> high.Shape then failwithf "Expecting low and high with the same shape, received %A, %A" low.Shape high.Shape
    member d.Low = low
    member d.High = high
    member private d.Range = high - low
    override d.Mean = (low + high) / 2.
    override d.Stddev = d.Range * d.Range / 12.f
    override d.Sample() = d.Low + Tensor.RandomLike(d.Low) * d.Range

type Normal(mean:Tensor, stddev:Tensor) =
    inherit Distribution()
    do if mean.Shape <> stddev.Shape then failwithf "Expecting mean and standard deviation with the same shape, received %A, %A" mean.Shape stddev.Shape
    override d.Mean = mean
    override d.Stddev = stddev
    override d.Sample() = d.Mean + Tensor.RandomNormalLike(d.Mean) * d.Stddev