# ☕ DripDoodle

**DripDoodle** is a cross-platform application that brings your imagination to life—by generating AI-powered doodles directly onto coffee cups. Built with React, ASP.NET Core, and Firebase AI (mocked in development), this app is designed for both fun and personalization.

## 🚀 Features

- 📸 Capture coffee cup images using your device camera
- ✍️ Type a prompt describing the doodle you want
- 🎨 AI-generated doodles (currently mocked for development)
- 🖼️ Real-time doodle preview overlaid on the cup
- 💾 Save or print the customized image (coming soon)

## 🛠️ Tech Stack

- **Frontend**: React.js
- **Backend**: ASP.NET Core Web API
- **AI Integration**: Firebase AI (coming Up), OpenAI (archived), Mocked the OpenAI call with a placeholder doodle for now
- **Camera Access**: Media Device APIs
- **Image Storage**: Firebase Storage / wwwroot
- **Auth (Planned)**: Firebase Authentication
- **Hosting**: Azure App Services / Firebase Hosting

## 📁 Project Status

This project is currently in its MVP phase with AI image generation mocked using local sample doodles. Future phases will include Firebase AI integration and full authentication.

## 📸 Mock Doodle Setup

To simulate the AI experience:
- Place your placeholder doodle in `/wwwroot/mock/sample-doodle.png`
- The backend copies it on each request with a dynamic filename
- The returned image URL mimics real-time AI output

## 🧩 Roadmap

- ✅ Camera + Prompt Input UI
- ✅ Backend with mocked AI image generation
- 🔜 Firebase AI integration
- 🔜 User authentication & profiles
- 🔜 Print-ready exports & templates
- 🔜 Launch portfolio-ready showcase

---

> ✨ “One commit closer to stars.” — the spirit behind DripDoodle
