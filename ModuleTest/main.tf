
module "TeamA" {
    source = "../Module"
    loc=var.loc1
    rsname=var.rs1

}

variable "loc1" {
    default = ""
}
variable "rs1" {
    default = ""
}


