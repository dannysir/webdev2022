package com.example.berywell

import android.content.Context
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.example.berywell.databinding.ScheduleBinding

class MyAdapter(private val context: Context) : RecyclerView.Adapter<MyAdapter.ViewHolder>() {

    var datas = mutableListOf<ScheduleData>()
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val view = LayoutInflater.from(context).inflate(R.layout.schedule,parent,false)
        return ViewHolder(view)
    }

    override fun getItemCount(): Int = datas.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        holder.bind(datas[position])
    }

    inner class ViewHolder(view: View) : RecyclerView.ViewHolder(view) {

        private val txtName: TextView = itemView.findViewById(R.id.myschedule_todo_text)
        private val txtAge: TextView = itemView.findViewById(R.id.myschedule_todoTime_text)
        private val imgProfile = itemView.findViewById<Button>(R.id.myschedule_check_btn)

        fun bind(item: ScheduleData) {
            txtName.text = item.name
            txtAge.text = item.time.toString()
            imgProfile.text = item.img.toString()
        }
    }


}