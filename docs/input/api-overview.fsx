﻿(*** hide ***)
#r "../../src/DiffSharp/bin/Debug/DiffSharp.dll"

(**
API Overview
============

The following table gives an overview of the differentiation API provided by the DiffSharp library.

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg th{font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;}
.tg .tg-a0td{font-size:100%}
.tg .tg-lgsi{font-size:100%;background-color:#ffffc7}
.tg .tg-u986{font-size:100%;background-color:#e4ffb3}
.tg .tg-40di{font-size:100%;background-color:#ecf4ff;color:#000000}
.tg .tg-dyge{font-weight:bold;font-size:100%}
.tg .tg-gkzk{font-size:100%;background-color:#ffffc7;text-align:center}
.tg .tg-v6es{font-size:100%;background-color:#e4ffb3;text-align:center}
.tg .tg-uy90{font-size:100%;background-color:#ecf4ff;color:#000000;text-align:center}
</style>
<table class="tg">
  <tr>
    <th class="tg-a0td"></th>
    <th class="tg-lgsi">diff</th>
    <th class="tg-lgsi">diff2</th>
    <th class="tg-lgsi">diffn</th>
    <th class="tg-u986">diffdir</th>
    <th class="tg-u986">grad</th>
    <th class="tg-u986">hessian</th>
    <th class="tg-u986">gradhessian</th>
    <th class="tg-u986">laplacian</th>
    <th class="tg-40di">jacobian</th>
  </tr>
  <tr>
    <td class="tg-dyge">DiffSharp.AD.Forward</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk"></td>
    <td class="tg-gkzk"></td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es"></td>
    <td class="tg-uy90">X</td>
  </tr>
  <tr>
    <td class="tg-dyge">DiffSharp.AD.Forward2</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk"></td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es">X</td>
    <td class="tg-uy90">X</td>
  </tr>
  <tr>
    <td class="tg-dyge">DiffSharp.AD.ForwardN</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es">X</td>
    <td class="tg-uy90">X</td>
  </tr>
  <tr>
    <td class="tg-dyge">DiffSharp.AD.ForwardV</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk"></td>
    <td class="tg-gkzk"></td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es"></td>
    <td class="tg-uy90">X</td>
  </tr>
  <tr>
    <td class="tg-dyge">DiffSharp.AD.ForwardV2</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk"></td>
    <td class="tg-gkzk"></td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-uy90">X</td>
  </tr>
  <tr>
    <td class="tg-dyge">DiffSharp.AD.Reverse</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk"></td>
    <td class="tg-gkzk"></td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">A</td>
    <td class="tg-v6es">XA</td>
    <td class="tg-v6es">A</td>
    <td class="tg-uy90">X</td>
  </tr>
  <tr>
    <td class="tg-dyge">DiffSharp.Numerical</td>
    <td class="tg-gkzk">A</td>
    <td class="tg-gkzk">A</td>
    <td class="tg-gkzk"></td>
    <td class="tg-v6es">A</td>
    <td class="tg-v6es">A</td>
    <td class="tg-v6es">A</td>
    <td class="tg-v6es">A</td>
    <td class="tg-v6es">A</td>
    <td class="tg-uy90">A</td>
  </tr>
  <tr>
    <td class="tg-dyge">DiffSharp.Symbolic</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-gkzk">X</td>
    <td class="tg-v6es"></td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-v6es">X</td>
    <td class="tg-uy90">X</td>
  </tr>
</table>

**Yellow**: Scalar-to-scalar functions; **Green**: Vector-to-scalar functions; **Blue**: Vector-to-vector functions

**X**: Exact value; **A**: Numerical approximation; **XA**: Exact gradient, approximated Hessian

Implemented Techniques
----------------------

The main focus of the DiffSharp library is AD, but we also implement symbolic and numerical differentiation.

Currently, the library provides the following implementations:

- DiffSharp.AD.Forward
- DiffSharp.AD.Forward2
- DiffSharp.AD.ForwardN
- DiffSharp.AD.ForwardV
- DiffSharp.AD.ForwardV2
- DiffSharp.AD.Reverse
- DiffSharp.Numerical
- DiffSharp.Symbolic

For brief explanations of these implementations, please refer to the [Forward AD](gettingstarted-forwardad.html), [Reverse AD](gettingstarted-reversead.html), [Numerical Differentiation](gettingstarted-numericaldifferentiation.html), and [Symbolic Differentiation](gettingstarted-symbolicdifferentiation.html) pages.

Operations and Variations
-------------------------

The operations summarized in the above table have _'-suffixed_ varieties that return a 2-tuple of (_value of original function_, _value of desired operation_). This is advantageous in the majority of AD computations, since the original function value has been already computed during AD computations, providing a performance advantage. 
*)

// Use forward AD
open DiffSharp.AD.Forward

// Derivative of Sin(Sqrt(x)) at x = 2
let a = diff (fun x -> sin (sqrt x)) 2.

// (Original value, derivative) of Sin(Sqrt(x)) at x = 2
let b, c = diff' (fun x -> sin (sqrt x)) 2.

(**
In addition to these, **jacobian** operations have _T-suffixed varieties_ returning the transposed version of the Jacobian matrix.

Currently, the library provides the following operations:

- **diff**: First derivative of a scalar-to-scalar function
- **diff'**: Original value and first derivative of a scalar-to-scalar function
- **diff2**: Second derivative of a scalar-to-scalar function
- **diff2'**: Original value and second derivative of a scalar-to-scalar function
- **diffn**: N-th derivative of a scalar-to-scalar function
- **diffn'**: Original value and n-th derivative of a scalar-to-scalar function
- **diffdir**: Directional derivative of a vector-to-scalar function
- **diffdir'**: Original value and directional derivative of a vector-to-scalar function
- **grad**: Gradient of a vector-to-scalar function
- **grad'**: Original value and gradient of a vector-to-scalar function
- **hessian**: Hessian of a vector-to-scalar function
- **hessian'**: Original value and Hessian of a vector-to-scalar function
- **gradhessian**: Gradient and Hessian of a vector-to-scalar function
- **gradhessian'**: Original value, gradient, and Hessian of a vector-to-scalar function
- **jacobian**: Jacobian of a vector-to-vector function
- **jacobian'**: Original value and Jacobian of a vector-to-vector function
- **jacobianT**: Transposed Jacobian of a vector-to-vector function
- **jacobianT'**: Original value and transposed Jacobian of a vector-to-vector function
- **laplacian**: Laplacian of a vector-to-scalar function
- **laplacian'**: Original value and Laplacian of a vector-to-scalar function

*)