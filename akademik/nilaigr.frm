TYPE=VIEW
query=select `akademik`.`dt_siswa`.`nm_siswa` AS `nm_siswa`,`akademik`.`dt_sis_skl`.`kls` AS `kls`,`akademik`.`dt_nilai`.`rt_tgs` AS `rt_tgs`,`akademik`.`dt_nilai`.`rt_uh` AS `rt_uh`,`akademik`.`dt_nilai`.`nil_mid` AS `nil_mid`,`akademik`.`dt_nilai`.`nil_smt` AS `nil_smt`,`akademik`.`dt_nilai`.`nil_akhr` AS `nil_akhr` from `akademik`.`dt_sis_skl` join `akademik`.`dt_nilai` join `akademik`.`dt_siswa` where ((`akademik`.`dt_sis_skl`.`nisn` = `akademik`.`dt_siswa`.`nisn`) and (`akademik`.`dt_nilai`.`nis` = `akademik`.`dt_sis_skl`.`nis`))
md5=c8d000a3995c53fde91807ec9ab29f7f
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
revision=1
timestamp=2015-04-08 15:02:21
create-version=1
source=select dt_siswa.nm_siswa,dt_sis_skl.kls,rt_tgs,rt_uh,nil_mid,nil_smt,nil_akhr from dt_sis_skl,dt_nilai,dt_siswa\nwhere dt_sis_skl.nisn = dt_siswa.nisn and dt_nilai.nis = dt_sis_skl.nis
