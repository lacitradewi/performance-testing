TYPE=VIEW
query=select `akademik`.`dt_pljr`.`kd_pljrn` AS `kd_pljrn`,`akademik`.`dt_pljr`.`nm_pljrn` AS `nm_pljrn`,`akademik`.`dt_nilai`.`rt_tgs` AS `rt_tgs`,`akademik`.`dt_nilai`.`rt_uh` AS `rt_uh`,`akademik`.`dt_nilai`.`nil_mid` AS `nil_mid`,`akademik`.`dt_nilai`.`nil_smt` AS `nil_smt`,`akademik`.`dt_nilai`.`nil_akhr` AS `nil_akhr` from `akademik`.`dt_nilai` join `akademik`.`dt_pljr` where (`akademik`.`dt_nilai`.`kd_pljrn` = `akademik`.`dt_pljr`.`kd_pljrn`)
md5=8bbb64a14ea89de81fdfd0f4f63b8b6f
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
revision=1
timestamp=2015-04-08 14:51:01
create-version=1
source=select dt_pljr.kd_pljrn,nm_pljrn,rt_tgs,rt_uh,nil_mid,nil_smt,nil_akhr\nfrom dt_nilai,dt_pljr where dt_nilai.kd_pljrn = dt_pljr.kd_pljrn
