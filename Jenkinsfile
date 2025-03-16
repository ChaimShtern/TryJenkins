pipeline {
    agent any
    environment {
        DOTNET_VERSION = '7.0'
    }
    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/ChaimShtern/TryJenkins.git'
            }
        }
        stage('Build') {
            steps {
                script {
                    sh 'dotnet build TryJenkins/TryJenkins.csproj'
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    sh 'dotnet test TryJenkins/TryJenkins.csproj'
                }
            }
        }
        stage('Run Application') {
            steps {
                script {
                    sh 'dotnet run --project TryJenkins/TryJenkins.csproj'
                }
            }
        }
    }
    post {
        success {
            echo 'Build succeeded!'
        }
        failure {
            echo 'Build failed!'
        }
    }
}
