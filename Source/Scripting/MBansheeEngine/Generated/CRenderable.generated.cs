using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Rendering
	 *  @{
	 */

	/// <summary>
	/// Renderable represents any visible object in the scene. It has a mesh, bounds and a set of materials. Renderer will 
	/// render any Renderable objects visible by a camera.
	/// </summary>
	[ShowInInspector]
	public partial class Renderable : Component
	{
		private Renderable(bool __dummy0) { }
		protected Renderable() { }

		/// <summary>
		/// Determines the mesh to render. All sub-meshes of the mesh will be rendered, and you may set individual materials for 
		/// each sub-mesh.
		/// </summary>
		[ShowInInspector]
		public RRef<Mesh> Mesh
		{
			get { return Internal_getMesh(mCachedPtr); }
			set { Internal_setMesh(mCachedPtr, value); }
		}

		/// <summary>
		/// Determines all materials used for rendering this renderable. Each of the materials is used for rendering a single 
		/// sub-mesh. If number of materials is larger than number of sub-meshes, they will be ignored. If lower, the remaining 
		/// materials will be removed.
		/// </summary>
		[ShowInInspector]
		public RRef<Material>[] Materials
		{
			get { return Internal_getMaterials(mCachedPtr); }
			set { Internal_setMaterials(mCachedPtr, value); }
		}

		/// <summary>
		/// Determines the layer bitfield that controls whether a renderable is considered visible in a specific camera.  
		/// Renderable layer must match camera layer in order for the camera to render the component.
		/// </summary>
		[ShowInInspector]
		public ulong Layers
		{
			get { return Internal_getLayer(mCachedPtr); }
			set { Internal_setLayer(mCachedPtr, value); }
		}

		/// <summary>Gets world bounds of the mesh rendered by this object.</summary>
		[ShowInInspector]
		public Bounds Bounds
		{
			get
			{
				Bounds temp;
				Internal_getBounds(mCachedPtr, out temp);
				return temp;
			}
		}

		/// <summary>
		/// Sets a material that will be used for rendering a sub-mesh with the specified index. If a sub-mesh doesn't have a 
		/// specific material set then the primary material will be used.
		/// </summary>
		public void SetMaterial(uint idx, RRef<Material> material)
		{
			Internal_setMaterial(mCachedPtr, idx, material);
		}

		/// <summary>
		/// Sets a material that will be used for rendering a sub-mesh with the specified index. If a sub-mesh doesn't have a 
		/// specific material set then the primary material will be used.
		/// </summary>
		public void SetMaterial(RRef<Material> material)
		{
			Internal_setMaterial0(mCachedPtr, material);
		}

		/// <summary>Returns the material used for rendering a sub-mesh with the specified index.</summary>
		public RRef<Material> GetMaterial(uint idx)
		{
			return Internal_getMaterial(mCachedPtr, idx);
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setMesh(IntPtr thisPtr, RRef<Mesh> mesh);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RRef<Mesh> Internal_getMesh(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setMaterial(IntPtr thisPtr, uint idx, RRef<Material> material);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setMaterial0(IntPtr thisPtr, RRef<Material> material);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RRef<Material> Internal_getMaterial(IntPtr thisPtr, uint idx);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setMaterials(IntPtr thisPtr, RRef<Material>[] materials);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RRef<Material>[] Internal_getMaterials(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setLayer(IntPtr thisPtr, ulong layer);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ulong Internal_getLayer(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_getBounds(IntPtr thisPtr, out Bounds __output);
	}

	/** @} */
}
