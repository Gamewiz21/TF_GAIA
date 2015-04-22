Shader "OpenGL/Panning"{
	Properties{
	_Color ("Ambient Color", Color) = (1.0,1.0,1.0,1.0)
	_MainTex ("Diffuse Texture", 2D) = "White" {}
	}

	SubShader {
		Pass{

		GLSLPROGRAM
		uniform vec4 _Time;
		uniform vec4 _Color;
		uniform sampler2D _MainTex;
		uniform vec4 _MainTex_ST;

		varying vec4 texCoords;
		
		varying vec3 vertexPosition;
		varying vec4 vertexColor;
		varying vec4 vertexData;
		varying vec2 uv;

		#ifdef VERTEX
		
		
		void main()
		
		{
		vertexColor = _Color;
			uv = gl_MultiTexCoord0;
			
			texCoords = gl_MultiTexCoord0;
			texCoords -= fract (_Time.x);
			gl_Position = gl_ModelViewProjectionMatrix * gl_Vertex;
		}

		#endif

		#ifdef FRAGMENT
		
		void main() 
		{
			gl_FragColor = texture2D(_MainTex, _MainTex_ST.xy * texCoords.xy + _MainTex_ST.zw ) * vertexColor;
		}

		#endif
		
		ENDGLSL
		}
	}

}