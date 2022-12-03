# 2022-11-29 TIL (1)

## Kotlin

## 날짜 또는 시간 입력 받기

---

앱에서 사용자에게 날짜나 시간을 입력받는데 사용하는 다이얼로그를 **피커 다이얼로그** 라고 합니다. 날짜를 입력받을 때는 데이트 피커 다이얼로그를, 시간을 입력받을 때는 타임 피커 다이얼로그를 사용합니다.

 날짜를 입력받는 데이트 피커 다이얼로그의 생성자는 다음과 같습니다.

```kotlin
DatePickerDialog(context: Context, listener: DatePickerDialog.OnDateSetListener?, year: Int, month: Int, dayOfMonth: Int)
```

 두 번째 매개변수로 DatePickerDialog.OnDateSetListener 구현 객체를 등록하면 다이얼로 그에서 사용자가 설정한 날짜를 콜백 함수로 얻을 수 있습니다. 나머지 Int 타입의 매개변수는 처음에 보이는 날짜입니다. month값은 0부터 11까지 지정되며 이때 0은 1월을 의미합니다.

```kotlin
DatePickerDialog(this, object: DatePickerDialog.OnDateSetListener{
	override fun onDateSet(p0: DatePicker?, p1: Int, p2: Int, p3: Int){
		Log.d("SanE", "year : $p1, month : ${p2 +1}, dayOfMonth : $p3")
	}
}, 2020, 8, 21).show()
```

 시간을 입력받는 타임 피커 다이얼로그의 생성자는 다음과 같습니다. 

```kotlin
TimePickerDialog(context: Context!, listener: TimePickerDialog.OnTimeSetListener!, hourOfDay: Int, minute: Int, is24HourView: Boolean)
```

 

 두 번째 매개변수로 TimePickerDialog.OnTimeSetListener를 구현한 객체를 지정하면 사용자가 다이얼로그에서 설정한 시간을 얻을 수 있으며 처음에 보일 시간을 Int 타입으로 설정할 수 있습니다. 

 그리고 마지막 매개변수로 시간을 24시간과 12시간 형태 중에 어떤 것으로 출력할 것인지를 지정합니다. false로 지정해 12시간 형태로 출력하면 오전/오후를 선택하는 부분이 보입니다. 반면에 true로 지정해 24시간 형태로 출력하면 오전/오후를 선택하는 부분이 보이지 않습니다. 

```kotlin
TimePickerDialog(this, object: TimePickerDialog.OnTimeSetListener{
	override fun onTimeSet(p0: TimePicker?, p1: Int, p2: Int){
		Log.d("SanE", "time: $p1, minute : $p2")
	}
}, 15, 0, true).show()
```

### 소리 알림

---

알림은은 카카오톡처럼 자체 녹음한 음원을 쓸 수도 있지만 안드로이드 시스템에 드록된 소리를 이용할 수도 있습니다. 먼저 시스템에 등록된 소리를 이용하는 방법을 살펴보겠습니다. 안드로이드 시스템은 알림, 알람, 벨소리 등의 소리를 제공하며 이 소리는 RingtonManager로 얻을 수 있습니다. 

```kotlin
val notification: Uri = RingtoneManager.getDefaultUri(RingtoneManager.TYPE_NOTIFICATION)
val ringtone = RingtoneManager.getRingtone(applicationContext, notification)
ringtone.play()
```

 먼저 RingtoneManager.getDefaultUri() 함수를 이용해 소리의 식별값을 얻습니다. 이식별값은 Uri 객체이며 이 값을 RingtoneManager.getRingtone() 함수의 두번째 매개변수로 전달하면 소리를 재생하는 Ringtone객체를 얻습니다. 이 Ringtone 객체의 play() 함수를 호출하면 비로소 소리가 재생됩니다. 

 이번에는 앱에서 자체 음원을 준비해서 재생하는 방법을 보겠습니다. 음원 파일은 리소스로 등록해서 이용해야 하는데 음원 리소스 디렉터리는 res/raw 입니다. 

 음원을 재생하는 클래스는 MediaPlayer입니다. 이 클래스에 리소스 정보를 지정하고 start() 함수를 호출하면 음원이 재생됩니다. 

```kotlin
val player: MediaPlayer = MediaPlayer.create(this, R.raw.fallbackring)
player.start()
```