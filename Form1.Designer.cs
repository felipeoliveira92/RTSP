
namespace RTSP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.videoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtCanal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.videoCapture2 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.videoCapture3 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.videoCapture4 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.btnPrint = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(917, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(917, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Desconectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // videoCapture1
            // 
            this.videoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture1.Audio_CaptureDevice = "";
            this.videoCapture1.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture1.Audio_CaptureDevice_Format = "";
            this.videoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Audio_CaptureDevice_Line = "";
            this.videoCapture1.Audio_CaptureDevice_MasterDevice = null;
            this.videoCapture1.Audio_CaptureDevice_MasterDevice_Format = null;
            this.videoCapture1.Audio_CaptureDevice_Path = null;
            this.videoCapture1.Audio_CaptureSourceFilter = null;
            this.videoCapture1.Audio_Channel_Mapper = null;
            this.videoCapture1.Audio_Decoder = null;
            this.videoCapture1.Audio_Effects_Enabled = false;
            this.videoCapture1.Audio_Effects_UseLegacyEffects = false;
            this.videoCapture1.Audio_Enhancer_Enabled = false;
            this.videoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture1.Audio_PCM_Converter = null;
            this.videoCapture1.Audio_PlayAudio = true;
            this.videoCapture1.Audio_RecordAudio = true;
            this.videoCapture1.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture1.BackColor = System.Drawing.Color.Black;
            this.videoCapture1.Barcode_Reader_Enabled = false;
            this.videoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture1.BDA_Source = null;
            this.videoCapture1.ChromaKey = null;
            this.videoCapture1.Custom_Source = null;
            this.videoCapture1.CustomRedist_Auto = true;
            this.videoCapture1.CustomRedist_DisableDialog = false;
            this.videoCapture1.CustomRedist_Enabled = false;
            this.videoCapture1.CustomRedist_Path = null;
            this.videoCapture1.Debug_Dir = "";
            this.videoCapture1.Debug_DisableMessageDialogs = false;
            this.videoCapture1.Debug_Mode = false;
            this.videoCapture1.Debug_Telemetry = true;
            this.videoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture1.Decklink_Input_IREUSA = false;
            this.videoCapture1.Decklink_Input_SMPTE = false;
            this.videoCapture1.Decklink_Output = null;
            this.videoCapture1.Decklink_Source = null;
            this.videoCapture1.DirectCapture_Muxer = null;
            this.videoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture1.Face_Tracking = null;
            this.videoCapture1.IP_Camera_Source = null;
            this.videoCapture1.Location = new System.Drawing.Point(12, 12);
            this.videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.videoCapture1.Motion_Detection = null;
            this.videoCapture1.Motion_DetectionEx = null;
            this.videoCapture1.MPEG_Audio_Decoder = "";
            this.videoCapture1.MPEG_Demuxer = null;
            this.videoCapture1.MPEG_Video_Decoder = "";
            this.videoCapture1.MultiScreen_Enabled = false;
            this.videoCapture1.Name = "videoCapture1";
            this.videoCapture1.Network_Streaming_Audio_Enabled = false;
            this.videoCapture1.Network_Streaming_Enabled = false;
            this.videoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture1.Network_Streaming_Network_Port = 100;
            this.videoCapture1.Network_Streaming_Output = null;
            this.videoCapture1.Network_Streaming_URL = "";
            this.videoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture1.OSD_Enabled = false;
            this.videoCapture1.Output_Filename = "C:\\Users\\Administrador\\Documents\\VisioForge\\output.avi";
            this.videoCapture1.Output_Format = null;
            this.videoCapture1.PIP_AddSampleGrabbers = false;
            this.videoCapture1.PIP_ChromaKeySettings = null;
            this.videoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture1.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.videoCapture1.Push_Source = null;
            this.videoCapture1.Screen_Capture_Source = null;
            this.videoCapture1.SeparateCapture_AutostartCapture = false;
            this.videoCapture1.SeparateCapture_Enabled = false;
            this.videoCapture1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.videoCapture1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture1.SeparateCapture_GMFMode = true;
            this.videoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture1.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.videoCapture1.Size = new System.Drawing.Size(420, 235);
            this.videoCapture1.Start_DelayEnabled = false;
            this.videoCapture1.TabIndex = 4;
            this.videoCapture1.Tags = null;
            this.videoCapture1.Timeshift_Settings = null;
            this.videoCapture1.TVTuner_Channel = 0;
            this.videoCapture1.TVTuner_Country = "";
            this.videoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture1.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture1.TVTuner_Frequency = 0;
            this.videoCapture1.TVTuner_InputType = "";
            this.videoCapture1.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
            this.videoCapture1.TVTuner_Name = "";
            this.videoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture1.Video_CaptureDevice = "";
            this.videoCapture1.Video_CaptureDevice_Format = "";
            this.videoCapture1.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture1.Video_CaptureDevice_Path = null;
            this.videoCapture1.Video_CaptureDevice_UseClosedCaptions = false;
            this.videoCapture1.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.videoCapture1.Video_Crop = null;
            this.videoCapture1.Video_Decoder = null;
            this.videoCapture1.Video_Effects_AllowMultipleStreams = false;
            this.videoCapture1.Video_Effects_Enabled = false;
            this.videoCapture1.Video_Effects_GPU_Enabled = false;
            this.videoCapture1.Video_Effects_MergeImageLogos = false;
            this.videoCapture1.Video_Effects_MergeTextLogos = false;
            this.videoCapture1.Video_Resize = null;
            this.videoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture1.Video_Sample_Grabber_Enabled = true;
            this.videoCapture1.Video_Sample_Grabber_UseForVideoEffects = true;
            this.videoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture1.VLC_Path = null;
            this.videoCapture1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.videoCapture1_MouseDoubleClick);
            // 
            // txtIp
            // 
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.Location = new System.Drawing.Point(973, 133);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(128, 22);
            this.txtIp.TabIndex = 7;
            this.txtIp.Text = "45.224.164.99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(877, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(877, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(877, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(877, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Porta RTSP";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(973, 163);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(128, 22);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.Text = "alarmaq";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(973, 194);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(128, 22);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.Text = "213388al";
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(973, 231);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(128, 22);
            this.txtPorta.TabIndex = 14;
            this.txtPorta.Text = "554";
            // 
            // txtCanal
            // 
            this.txtCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanal.Location = new System.Drawing.Point(973, 261);
            this.txtCanal.Name = "txtCanal";
            this.txtCanal.Size = new System.Drawing.Size(128, 22);
            this.txtCanal.TabIndex = 16;
            this.txtCanal.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(877, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Channel";
            // 
            // videoCapture2
            // 
            this.videoCapture2.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture2.Audio_CaptureDevice = "";
            this.videoCapture2.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture2.Audio_CaptureDevice_Format = "";
            this.videoCapture2.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture2.Audio_CaptureDevice_Line = "";
            this.videoCapture2.Audio_CaptureDevice_MasterDevice = null;
            this.videoCapture2.Audio_CaptureDevice_MasterDevice_Format = null;
            this.videoCapture2.Audio_CaptureDevice_Path = null;
            this.videoCapture2.Audio_CaptureSourceFilter = null;
            this.videoCapture2.Audio_Channel_Mapper = null;
            this.videoCapture2.Audio_Decoder = null;
            this.videoCapture2.Audio_Effects_Enabled = false;
            this.videoCapture2.Audio_Effects_UseLegacyEffects = false;
            this.videoCapture2.Audio_Enhancer_Enabled = false;
            this.videoCapture2.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture2.Audio_PCM_Converter = null;
            this.videoCapture2.Audio_PlayAudio = true;
            this.videoCapture2.Audio_RecordAudio = true;
            this.videoCapture2.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture2.Audio_VUMeter_Enabled = false;
            this.videoCapture2.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture2.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture2.BackColor = System.Drawing.Color.Black;
            this.videoCapture2.Barcode_Reader_Enabled = false;
            this.videoCapture2.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture2.BDA_Source = null;
            this.videoCapture2.ChromaKey = null;
            this.videoCapture2.Custom_Source = null;
            this.videoCapture2.CustomRedist_Auto = true;
            this.videoCapture2.CustomRedist_DisableDialog = false;
            this.videoCapture2.CustomRedist_Enabled = false;
            this.videoCapture2.CustomRedist_Path = null;
            this.videoCapture2.Debug_Dir = "";
            this.videoCapture2.Debug_DisableMessageDialogs = false;
            this.videoCapture2.Debug_Mode = false;
            this.videoCapture2.Debug_Telemetry = true;
            this.videoCapture2.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture2.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture2.Decklink_Input_IREUSA = false;
            this.videoCapture2.Decklink_Input_SMPTE = false;
            this.videoCapture2.Decklink_Output = null;
            this.videoCapture2.Decklink_Source = null;
            this.videoCapture2.DirectCapture_Muxer = null;
            this.videoCapture2.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture2.Face_Tracking = null;
            this.videoCapture2.IP_Camera_Source = null;
            this.videoCapture2.Location = new System.Drawing.Point(434, 12);
            this.videoCapture2.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.videoCapture2.Motion_Detection = null;
            this.videoCapture2.Motion_DetectionEx = null;
            this.videoCapture2.MPEG_Audio_Decoder = "";
            this.videoCapture2.MPEG_Demuxer = null;
            this.videoCapture2.MPEG_Video_Decoder = "";
            this.videoCapture2.MultiScreen_Enabled = false;
            this.videoCapture2.Name = "videoCapture2";
            this.videoCapture2.Network_Streaming_Audio_Enabled = false;
            this.videoCapture2.Network_Streaming_Enabled = false;
            this.videoCapture2.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture2.Network_Streaming_Network_Port = 100;
            this.videoCapture2.Network_Streaming_Output = null;
            this.videoCapture2.Network_Streaming_URL = "";
            this.videoCapture2.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture2.OSD_Enabled = false;
            this.videoCapture2.Output_Filename = "C:\\Users\\Administrador\\Documents\\VisioForge\\output.avi";
            this.videoCapture2.Output_Format = null;
            this.videoCapture2.PIP_AddSampleGrabbers = false;
            this.videoCapture2.PIP_ChromaKeySettings = null;
            this.videoCapture2.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture2.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.videoCapture2.Push_Source = null;
            this.videoCapture2.Screen_Capture_Source = null;
            this.videoCapture2.SeparateCapture_AutostartCapture = false;
            this.videoCapture2.SeparateCapture_Enabled = false;
            this.videoCapture2.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.videoCapture2.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture2.SeparateCapture_GMFMode = true;
            this.videoCapture2.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture2.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.videoCapture2.Size = new System.Drawing.Size(420, 235);
            this.videoCapture2.Start_DelayEnabled = false;
            this.videoCapture2.TabIndex = 5;
            this.videoCapture2.Tags = null;
            this.videoCapture2.Timeshift_Settings = null;
            this.videoCapture2.TVTuner_Channel = 0;
            this.videoCapture2.TVTuner_Country = "";
            this.videoCapture2.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture2.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture2.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture2.TVTuner_Frequency = 0;
            this.videoCapture2.TVTuner_InputType = "";
            this.videoCapture2.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
            this.videoCapture2.TVTuner_Name = "";
            this.videoCapture2.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture2.Video_CaptureDevice = "";
            this.videoCapture2.Video_CaptureDevice_Format = "";
            this.videoCapture2.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture2.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture2.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture2.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture2.Video_CaptureDevice_Path = null;
            this.videoCapture2.Video_CaptureDevice_UseClosedCaptions = false;
            this.videoCapture2.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.videoCapture2.Video_Crop = null;
            this.videoCapture2.Video_Decoder = null;
            this.videoCapture2.Video_Effects_AllowMultipleStreams = false;
            this.videoCapture2.Video_Effects_Enabled = false;
            this.videoCapture2.Video_Effects_GPU_Enabled = false;
            this.videoCapture2.Video_Effects_MergeImageLogos = false;
            this.videoCapture2.Video_Effects_MergeTextLogos = false;
            this.videoCapture2.Video_Resize = null;
            this.videoCapture2.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture2.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture2.Video_Sample_Grabber_Enabled = true;
            this.videoCapture2.Video_Sample_Grabber_UseForVideoEffects = true;
            this.videoCapture2.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture2.Virtual_Camera_Output_Enabled = false;
            this.videoCapture2.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture2.VLC_Path = null;
            this.videoCapture2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.videoCapture2_MouseClick);
            // 
            // videoCapture3
            // 
            this.videoCapture3.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture3.Audio_CaptureDevice = "";
            this.videoCapture3.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture3.Audio_CaptureDevice_Format = "";
            this.videoCapture3.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture3.Audio_CaptureDevice_Line = "";
            this.videoCapture3.Audio_CaptureDevice_MasterDevice = null;
            this.videoCapture3.Audio_CaptureDevice_MasterDevice_Format = null;
            this.videoCapture3.Audio_CaptureDevice_Path = null;
            this.videoCapture3.Audio_CaptureSourceFilter = null;
            this.videoCapture3.Audio_Channel_Mapper = null;
            this.videoCapture3.Audio_Decoder = null;
            this.videoCapture3.Audio_Effects_Enabled = false;
            this.videoCapture3.Audio_Effects_UseLegacyEffects = false;
            this.videoCapture3.Audio_Enhancer_Enabled = false;
            this.videoCapture3.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture3.Audio_PCM_Converter = null;
            this.videoCapture3.Audio_PlayAudio = true;
            this.videoCapture3.Audio_RecordAudio = true;
            this.videoCapture3.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture3.Audio_VUMeter_Enabled = false;
            this.videoCapture3.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture3.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture3.BackColor = System.Drawing.Color.Black;
            this.videoCapture3.Barcode_Reader_Enabled = false;
            this.videoCapture3.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture3.BDA_Source = null;
            this.videoCapture3.ChromaKey = null;
            this.videoCapture3.Custom_Source = null;
            this.videoCapture3.CustomRedist_Auto = true;
            this.videoCapture3.CustomRedist_DisableDialog = false;
            this.videoCapture3.CustomRedist_Enabled = false;
            this.videoCapture3.CustomRedist_Path = null;
            this.videoCapture3.Debug_Dir = "";
            this.videoCapture3.Debug_DisableMessageDialogs = false;
            this.videoCapture3.Debug_Mode = false;
            this.videoCapture3.Debug_Telemetry = true;
            this.videoCapture3.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture3.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture3.Decklink_Input_IREUSA = false;
            this.videoCapture3.Decklink_Input_SMPTE = false;
            this.videoCapture3.Decklink_Output = null;
            this.videoCapture3.Decklink_Source = null;
            this.videoCapture3.DirectCapture_Muxer = null;
            this.videoCapture3.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture3.Face_Tracking = null;
            this.videoCapture3.IP_Camera_Source = null;
            this.videoCapture3.Location = new System.Drawing.Point(12, 248);
            this.videoCapture3.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.videoCapture3.Motion_Detection = null;
            this.videoCapture3.Motion_DetectionEx = null;
            this.videoCapture3.MPEG_Audio_Decoder = "";
            this.videoCapture3.MPEG_Demuxer = null;
            this.videoCapture3.MPEG_Video_Decoder = "";
            this.videoCapture3.MultiScreen_Enabled = false;
            this.videoCapture3.Name = "videoCapture3";
            this.videoCapture3.Network_Streaming_Audio_Enabled = false;
            this.videoCapture3.Network_Streaming_Enabled = false;
            this.videoCapture3.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture3.Network_Streaming_Network_Port = 100;
            this.videoCapture3.Network_Streaming_Output = null;
            this.videoCapture3.Network_Streaming_URL = "";
            this.videoCapture3.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture3.OSD_Enabled = false;
            this.videoCapture3.Output_Filename = "C:\\Users\\Administrador\\Documents\\VisioForge\\output.avi";
            this.videoCapture3.Output_Format = null;
            this.videoCapture3.PIP_AddSampleGrabbers = false;
            this.videoCapture3.PIP_ChromaKeySettings = null;
            this.videoCapture3.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture3.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.videoCapture3.Push_Source = null;
            this.videoCapture3.Screen_Capture_Source = null;
            this.videoCapture3.SeparateCapture_AutostartCapture = false;
            this.videoCapture3.SeparateCapture_Enabled = false;
            this.videoCapture3.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.videoCapture3.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture3.SeparateCapture_GMFMode = true;
            this.videoCapture3.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture3.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.videoCapture3.Size = new System.Drawing.Size(420, 235);
            this.videoCapture3.Start_DelayEnabled = false;
            this.videoCapture3.TabIndex = 5;
            this.videoCapture3.Tags = null;
            this.videoCapture3.Timeshift_Settings = null;
            this.videoCapture3.TVTuner_Channel = 0;
            this.videoCapture3.TVTuner_Country = "";
            this.videoCapture3.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture3.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture3.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture3.TVTuner_Frequency = 0;
            this.videoCapture3.TVTuner_InputType = "";
            this.videoCapture3.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
            this.videoCapture3.TVTuner_Name = "";
            this.videoCapture3.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture3.Video_CaptureDevice = "";
            this.videoCapture3.Video_CaptureDevice_Format = "";
            this.videoCapture3.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture3.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture3.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture3.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture3.Video_CaptureDevice_Path = null;
            this.videoCapture3.Video_CaptureDevice_UseClosedCaptions = false;
            this.videoCapture3.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.videoCapture3.Video_Crop = null;
            this.videoCapture3.Video_Decoder = null;
            this.videoCapture3.Video_Effects_AllowMultipleStreams = false;
            this.videoCapture3.Video_Effects_Enabled = false;
            this.videoCapture3.Video_Effects_GPU_Enabled = false;
            this.videoCapture3.Video_Effects_MergeImageLogos = false;
            this.videoCapture3.Video_Effects_MergeTextLogos = false;
            this.videoCapture3.Video_Resize = null;
            this.videoCapture3.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture3.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture3.Video_Sample_Grabber_Enabled = true;
            this.videoCapture3.Video_Sample_Grabber_UseForVideoEffects = true;
            this.videoCapture3.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture3.Virtual_Camera_Output_Enabled = false;
            this.videoCapture3.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture3.VLC_Path = null;
            // 
            // videoCapture4
            // 
            this.videoCapture4.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture4.Audio_CaptureDevice = "";
            this.videoCapture4.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture4.Audio_CaptureDevice_Format = "";
            this.videoCapture4.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture4.Audio_CaptureDevice_Line = "";
            this.videoCapture4.Audio_CaptureDevice_MasterDevice = null;
            this.videoCapture4.Audio_CaptureDevice_MasterDevice_Format = null;
            this.videoCapture4.Audio_CaptureDevice_Path = null;
            this.videoCapture4.Audio_CaptureSourceFilter = null;
            this.videoCapture4.Audio_Channel_Mapper = null;
            this.videoCapture4.Audio_Decoder = null;
            this.videoCapture4.Audio_Effects_Enabled = false;
            this.videoCapture4.Audio_Effects_UseLegacyEffects = false;
            this.videoCapture4.Audio_Enhancer_Enabled = false;
            this.videoCapture4.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture4.Audio_PCM_Converter = null;
            this.videoCapture4.Audio_PlayAudio = true;
            this.videoCapture4.Audio_RecordAudio = true;
            this.videoCapture4.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture4.Audio_VUMeter_Enabled = false;
            this.videoCapture4.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture4.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture4.BackColor = System.Drawing.Color.Black;
            this.videoCapture4.Barcode_Reader_Enabled = false;
            this.videoCapture4.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture4.BDA_Source = null;
            this.videoCapture4.ChromaKey = null;
            this.videoCapture4.Custom_Source = null;
            this.videoCapture4.CustomRedist_Auto = true;
            this.videoCapture4.CustomRedist_DisableDialog = false;
            this.videoCapture4.CustomRedist_Enabled = false;
            this.videoCapture4.CustomRedist_Path = null;
            this.videoCapture4.Debug_Dir = "";
            this.videoCapture4.Debug_DisableMessageDialogs = false;
            this.videoCapture4.Debug_Mode = false;
            this.videoCapture4.Debug_Telemetry = true;
            this.videoCapture4.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture4.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture4.Decklink_Input_IREUSA = false;
            this.videoCapture4.Decklink_Input_SMPTE = false;
            this.videoCapture4.Decklink_Output = null;
            this.videoCapture4.Decklink_Source = null;
            this.videoCapture4.DirectCapture_Muxer = null;
            this.videoCapture4.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture4.Face_Tracking = null;
            this.videoCapture4.IP_Camera_Source = null;
            this.videoCapture4.Location = new System.Drawing.Point(434, 248);
            this.videoCapture4.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.videoCapture4.Motion_Detection = null;
            this.videoCapture4.Motion_DetectionEx = null;
            this.videoCapture4.MPEG_Audio_Decoder = "";
            this.videoCapture4.MPEG_Demuxer = null;
            this.videoCapture4.MPEG_Video_Decoder = "";
            this.videoCapture4.MultiScreen_Enabled = false;
            this.videoCapture4.Name = "videoCapture4";
            this.videoCapture4.Network_Streaming_Audio_Enabled = false;
            this.videoCapture4.Network_Streaming_Enabled = false;
            this.videoCapture4.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture4.Network_Streaming_Network_Port = 100;
            this.videoCapture4.Network_Streaming_Output = null;
            this.videoCapture4.Network_Streaming_URL = "";
            this.videoCapture4.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture4.OSD_Enabled = false;
            this.videoCapture4.Output_Filename = "C:\\Users\\Administrador\\Documents\\VisioForge\\output.avi";
            this.videoCapture4.Output_Format = null;
            this.videoCapture4.PIP_AddSampleGrabbers = false;
            this.videoCapture4.PIP_ChromaKeySettings = null;
            this.videoCapture4.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture4.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.videoCapture4.Push_Source = null;
            this.videoCapture4.Screen_Capture_Source = null;
            this.videoCapture4.SeparateCapture_AutostartCapture = false;
            this.videoCapture4.SeparateCapture_Enabled = false;
            this.videoCapture4.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.videoCapture4.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture4.SeparateCapture_GMFMode = true;
            this.videoCapture4.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture4.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.videoCapture4.Size = new System.Drawing.Size(420, 235);
            this.videoCapture4.Start_DelayEnabled = false;
            this.videoCapture4.TabIndex = 5;
            this.videoCapture4.Tags = null;
            this.videoCapture4.Timeshift_Settings = null;
            this.videoCapture4.TVTuner_Channel = 0;
            this.videoCapture4.TVTuner_Country = "";
            this.videoCapture4.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture4.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture4.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture4.TVTuner_Frequency = 0;
            this.videoCapture4.TVTuner_InputType = "";
            this.videoCapture4.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
            this.videoCapture4.TVTuner_Name = "";
            this.videoCapture4.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture4.Video_CaptureDevice = "";
            this.videoCapture4.Video_CaptureDevice_Format = "";
            this.videoCapture4.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture4.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture4.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture4.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture4.Video_CaptureDevice_Path = null;
            this.videoCapture4.Video_CaptureDevice_UseClosedCaptions = false;
            this.videoCapture4.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.videoCapture4.Video_Crop = null;
            this.videoCapture4.Video_Decoder = null;
            this.videoCapture4.Video_Effects_AllowMultipleStreams = false;
            this.videoCapture4.Video_Effects_Enabled = false;
            this.videoCapture4.Video_Effects_GPU_Enabled = false;
            this.videoCapture4.Video_Effects_MergeImageLogos = false;
            this.videoCapture4.Video_Effects_MergeTextLogos = false;
            this.videoCapture4.Video_Resize = null;
            this.videoCapture4.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture4.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture4.Video_Sample_Grabber_Enabled = true;
            this.videoCapture4.Video_Sample_Grabber_UseForVideoEffects = true;
            this.videoCapture4.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture4.Virtual_Camera_Output_Enabled = false;
            this.videoCapture4.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture4.VLC_Path = null;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(917, 440);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(128, 43);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG Files|*.jpg|GIF Files|*.gif|PNG Files|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 495);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.videoCapture4);
            this.Controls.Add(this.videoCapture3);
            this.Controls.Add(this.videoCapture2);
            this.Controls.Add(this.txtCanal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.videoCapture1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DooR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtCanal;
        private System.Windows.Forms.Label label5;
        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture2;
        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture3;
        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

