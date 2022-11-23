package com.example.berywell

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.berywell.databinding.MyscheduleBinding

class MySchedule:AppCompatActivity() {
    lateinit var profileAdapter: MyAdapter
    val datas = mutableListOf<ScheduleData>()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        initRecycler()
    }
    private fun initRecycler() {
        profileAdapter = MyAdapter(this)
         //rv_profile.adapter = profileAdapter
        val binding = MyscheduleBinding.inflate(layoutInflater)
        binding.recyclerView.adapter = profileAdapter

        datas.apply {
            add(ScheduleData(img = R.drawable.round_shape_green, name = "운동하기", time = 24))
            add(ScheduleData(img = R.drawable.round_shape_green, name = "운동하기", time = 26))
            add(ScheduleData(img = R.drawable.round_shape_green, name = "운동하기", time = 27))
            add(ScheduleData(img = R.drawable.round_shape_green, name = "운동하기", time = 21))
            add(ScheduleData(img = R.drawable.round_shape_green, name = "운동하기", time = 23))

            profileAdapter.datas = datas
            profileAdapter.notifyDataSetChanged()

        }
    }
}