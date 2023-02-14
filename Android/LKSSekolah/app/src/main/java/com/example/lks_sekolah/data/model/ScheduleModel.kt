package com.example.lks_sekolah.data.model

import android.os.Parcelable
import kotlinx.parcelize.Parcelize


@Parcelize
data class ScheduleModel(
    var subjcetId : String?,
    var subject : String?,
    var className : String?,
    var teacherName : String?
) :Parcelable