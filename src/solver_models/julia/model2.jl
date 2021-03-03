#import Pkg
#Pkg.add("JSON") 
using JSON
println(JSON.parse(ARGS[2]))
dct=JSON.parse(ARGS[2])
@show dct
println(dct["data"])
data = dct["data"]
#println(ARGS[1])
b=tuple(1, 'a', pi)
#println(b)

function f(x)
    println(@isdefined x)
    x = 3
    println(@isdefined x)
end

#f(45)

#print([1 2 3]*3)
#if(length(data)>1)
print(typeof(data))