<div align="center">

# 🍅 Pamodoro Timer

**A sleek Windows desktop Pomodoro timer with a live circular progress gauge, built with C# and DevExpress.**

![Platform](https://img.shields.io/badge/platform-Windows-0078D6?style=flat-square&logo=windows)
![Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=flat-square&logo=dotnet)
![UI](https://img.shields.io/badge/UI-DevExpress%20v23.1-FF6600?style=flat-square)
![Language](https://img.shields.io/badge/C%23-WinForms-239120?style=flat-square&logo=c-sharp)

</div>

---

## 📸 Screenshots

<div align="center">

![Pamodoro Timer screenshot](https://github.com/osamasu/Pamodoro-Timer/assets/97795269/e63e65b3-f946-4444-84fc-4ca8a88ef190)

![Pamodoro Timer screenshot](https://github.com/osamasu/Pamodoro-Timer/assets/97795269/7c2dec03-9987-4597-8aba-547b0d0cbf17)

</div>

---

## ✨ About

**Pamodoro Timer** is a lightweight Windows desktop app that implements the [Pomodoro Technique](https://en.wikipedia.org/wiki/Pomodoro_Technique) — a time-management method that alternates focused work sessions with short breaks. The app automatically cycles between **Study Mode** and **Rest Mode**, visualizing progress with an animated circular gauge and notifying you with a sound when a session ends.

## 🚀 Features

- ⏱️ **Study / Rest cycle** — automatically alternates between focused work and break sessions
- 🎯 **Live circular progress gauge** — a visual arc gauge fills in real time as each session progresses, color-coded per mode
- ⚙️ **Fully customizable durations** — set your own study time and rest time from the Settings panel
- 🔊 **Audible alerts** — plays a sound and brings the window to focus when a session completes
- 🖥️ **Polished DevExpress UI** — modern ribbon bar, gauges, and editors
- ℹ️ **About dialog** — quick links to the developer's contact info

## 🛠️ Tech Stack

| Layer         | Technology                                    |
|---------------|------------------------------------------------|
| Language      | C#                                              |
| UI Framework  | Windows Forms (WinForms)                        |
| Target        | .NET Framework 4.8                              |
| UI Components | [DevExpress WinForms v23.1](https://www.devexpress.com/products/net/controls/winforms/) (XtraEditors, XtraBars, XtraGauges) |
| Icons         | [FontAwesome.Sharp](https://github.com/awesome-inc/FontAwesome.Sharp) |
| Packaging     | Visual Studio Setup Project (MSI installer)     |

## 📦 Getting Started

### Prerequisites

- Windows OS
- [.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
- To build from source: Visual Studio 2019+ with a [DevExpress WinForms v23.1](https://www.devexpress.com/products/net/controls/winforms/) license/installation

### Option A — Install the app

Run the installer from the [`Setup1`](./Setup1) folder (`Pamadora.msi`, Debug or Release build) to install the app on your machine.

### Option B — Build from source

```bash
git clone https://github.com/osamasu/Pamodoro-Timer.git
cd Pamodoro-Timer
```

1. Open `Pamodoro Time.sln` in Visual Studio.
2. Ensure the DevExpress v23.1 assemblies and FontAwesome.Sharp are available/restored.
3. Build and run the `Pamodoro Time` project (F5).

## 🎮 Usage

1. Launch the app — it starts in **Study Mode** with the default duration.
2. Click **Start** to begin the countdown; the gauge fills as time passes.
3. When a session ends, a sound plays and the app switches automatically to **Rest Mode** (and back).
4. Open **Settings** at any time to customize the study and rest durations.
5. Open the **About** dialog for developer contact links.

## 📁 Project Structure

```
Pamodoro-Timer/
├── Pamodoro.cs           # Main timer form — gauge, countdown, mode switching
├── FrmSettings.cs        # Settings dialog — customize study/rest durations
├── FrmAbout.cs           # About dialog — developer contact links
├── Program.cs            # App entry point & settings persistence
├── Resources/            # Icons, images, and alert sound
└── Setup1/                # MSI installer project (Debug/Release)
```

## 📄 License

This project is shared as an open portfolio project. Feel free to explore the source, learn from it, or use it as a reference — no formal license is currently attached to this repository.

## 👤 Contact

**Osama Thabit**

- 📧 Email: [Osamataher306@Outlook.com](mailto:Osamataher306@Outlook.com)
- 💼 LinkedIn: [osama-thabit-mohammed](https://www.linkedin.com/in/osama-thabit-mohammed)
- 🐙 GitHub: [@osamasu](https://github.com/osamasu)
