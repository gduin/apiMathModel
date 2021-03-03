library(jsonlite)

main <- function() {

#### Fetch command line arguments
myArgs <- commandArgs(trailingOnly = TRUE)

#### myArgs is a character vector of all arguments
###print(myArgs)
###print(class(myArgs))
data<-fromJSON(myArgs[2])
##print("JSON ")
##print(data[2])
##print(class(data[1]))
dd<-rnorm(10)
#print(dd)
x2_imp <-lapply(dd, function(x){x*x})
#print(x2_imp)
result<-lapply( data, function(x) {x**3})

print(list(result))
result<-toJSON(result)
print(result[1])
print(class(result))
return(result)
#  args <- commandArgs(trailingOnly = TRUE)

#  for (filename in args) {
#    dat <- read.csv(file = filename, header = FALSE)
#    mean_per_patient <- apply(dat, 1, mean)
#    cat(mean_per_patient, sep = "\n")
#  }
}

main()